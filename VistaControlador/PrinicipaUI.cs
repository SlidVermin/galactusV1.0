using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections;
using System.Globalization;

namespace Galactus
{
    public partial class PrincipalUI : Form
    {
        public MenuStrip MenuOpciones = new MenuStrip();
        private static SqlConnection cnxion = Sesion.getConexion();

        public static SqlConnection Cnxion
        {
            get
            {
                return cnxion;
            }
            set
            {
                cnxion = value;
            }
        }

        private int childFormNumber = 0;
        public PrincipalUI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            crearMenu();
            this.WindowState = FormWindowState.Maximized;
            toolStripStatusLabel.Text = Sesion.nombre;
        }

        void crearMenu()
        {
            MenuOpciones = cargarMenu();
            this.Controls.Add(MenuOpciones);
            MenuOpciones.LayoutStyle = ToolStripLayoutStyle.Flow;
            MenuOpciones.AutoSize = true;
            MenuOpciones.BackColor = Color.FromArgb(230, 230, 230);
            MenuOpciones.GripStyle = ToolStripGripStyle.Visible;
            MenuOpciones.Renderer = new MyRenderer();
        }
        public MenuStrip cargarMenu()
        {
            MenuStrip menu = new MenuStrip();
            List<string> pamaetros = new List<string>();
            pamaetros.Add(Sesion.IdRol.ToString());
            GeneralC.llenarTabla(Query.SEG_ARMAR_MENU, pamaetros, Sesion.dtmenu);
            GeneralC.llenarTabla(Query.SEG_LLENAR_PERMISOS, pamaetros, Sesion.dtPermisos);
            return colocarPadres(menu);
        }
        public MenuStrip colocarPadres(MenuStrip menu)
        {
            DataRow[] filas = null;
            filas = Sesion.dtmenu.Select("IdMenuPadre is null");

            ToolStripMenuItem menuPadre = null;
            if (filas != null)
            {
                foreach (DataRow fila in filas)
                {
                    DictionaryEntry itemEncontrado = obtenerImagen(fila.Field<string>("imagen"));
                    menuPadre = new ToolStripMenuItem(fila.Field<string>("Descripcion"), (Image)itemEncontrado.Value);
                    colocarHijo(fila.Field<int>("IdMenu"), menuPadre);
                    menu.Items.Add(menuPadre);
                }
            }
            menuPadre = new ToolStripMenuItem("Salir");
            menuPadre.Alignment = ToolStripItemAlignment.Right;
            agregarMenuItem("Salir", menuPadre);
            menu.Items.Add(menuPadre);
            return menu;
        }
        public DictionaryEntry obtenerImagen(string nombre)
        {
            DictionaryEntry itemEncontrado;
            var lista = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, true);
          
            foreach (DictionaryEntry imagen in Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, true))
            {             
                if (imagen.Key.Equals(nombre))
                {
                    itemEncontrado = imagen;
                    break;
                }
            }
            return itemEncontrado;
        }
        public void colocarHijo(int codigo, ToolStripMenuItem menuPadre)
        {
            DataRow[] filas = null;
            filas = Sesion.dtmenu.Select("IdMenuPadre is not null and IdMenuPadre = '" + codigo + "'");
            InformacionTag info;
            if (filas != null)
            {
                foreach (DataRow item in filas)
                {
                    info = new InformacionTag();
                    info.IdMenu = item.Field<int>("idMenu");
                    info.Nombre = item.Field<string>("Descripcion");

                    info.NombreForm = item.Field<string>("Formulario");
                    ToolStripMenuItem subItem = new ToolStripMenuItem(info.Nombre, null);
                    if (info.NombreForm != null)
                    {
                        agregarMenuItem(info.NombreForm, subItem);
                    }
                    subItem.Name = info.Nombre;
                    subItem.Tag = info;
                    colocarHijo(info.IdMenu, subItem);
                    menuPadre.DropDownItems.Add(subItem);
                }
            }
        }
        public void agregarMenuItem(string form, ToolStripMenuItem mnuSubOpcion)
        {
            switch (form)
            {
                case "Salir":
                    mnuSubOpcion.Click += new EventHandler(salir);
                    break;
                default:
                    mnuSubOpcion.Click += new EventHandler(cargarFormulario);
                    break;

            }
        }
        public void salir(Object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        public void cargarFormulario(Object sender, EventArgs e)
        {
            try
            {
                var menuItem = (ToolStripMenuItem)sender;
                var NombreNuevaInstancia = Assembly.GetExecutingAssembly().GetName().Name;
                InformacionTag info = new InformacionTag();
                info = (InformacionTag)menuItem.Tag;
                Type vTipo = null;
                var a = Assembly.GetExecutingAssembly().GetTypes();
                foreach (var item in a)
                {
                    if (item.Name.Equals(info.NombreForm))
                    {
                        vTipo = Assembly.GetExecutingAssembly().GetType(item.FullName);
                        break;
                    }
                }

                if (vTipo != null)
                {
                    var vFormulario = (Form)Activator.CreateInstance(vTipo);
                    vFormulario.Tag = info.IdMenu;
                    GeneralC.cargarForm(vFormulario, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PrincipalUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
