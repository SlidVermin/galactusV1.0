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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("los campos marcados son obligatorios", "", MessageBoxButtons.OK);
            }
            else
            {
                iniciarSesion(txtUsuario.Text, txtPass.Text);
            }
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
                    PriincipalUI formPrincipal = new PriincipalUI();
                    formPrincipal.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        public  bool iniciarSesion(List<string> listaParametros)
        {
            DataRow filaResultado = null;
            filaResultado = GeneralC.devuelveUnaFila(Query.SEG_AUTENTICACION, listaParametros);
            if (filaResultado != null)
            {
                Sesion.IdRol = (int)filaResultado.ItemArray[0];
                Sesion.IdUsuario = (int)filaResultado.ItemArray[1];
                Sesion.nombre = filaResultado.Field<string>("Nombre");
                return true;
            }
            return false;
        }

    }
}
