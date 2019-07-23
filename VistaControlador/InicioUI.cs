using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus
{
    public partial class InicioUI : Form
    {
        public InicioUI()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(200, 107, 107, 107);
            lblUsuario.BackColor = Color.Transparent;
            lblContrasena.BackColor = Color.Transparent;
            lbSede.BackColor = Color.Transparent;
            btIngresar.BackColor = Color.FromArgb(180, 131, 173, 210);
            btSalir.BackColor = Color.FromArgb(180, 131, 173, 210);
        }

        void iniciarSesion(string usuario, string pass)
        {
            try
            {
                List<string> list = new List<string>();
                list.Add(usuario);
                list.Add(pass);
                if (iniciarSesion(list))
                {
                    PrincipalUI principalUI = new PrincipalUI();
                    principalUI.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        public bool iniciarSesion(List<string> listaParametros)
        {
            DataRow filaResultado = null;
            filaResultado = GeneralC.devuelveUnaFila(Sentencias.SEG_AUTENTICACION, listaParametros);
            if (filaResultado != null)
            {
                Sesion.IdRol = (int)filaResultado.ItemArray[0];
                Sesion.IdUsuario = (int)filaResultado.ItemArray[1];
                Sesion.nombre = filaResultado.Field<string>("Nombre");
                return true;
            }
            return false;
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("los campos marcados son obligatorios", "", MessageBoxButtons.OK);
            }
            else
            {
                iniciarSesion(txtUsuario.Text, txtContrasena.Text);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
