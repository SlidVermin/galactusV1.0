using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Galactus
{

    class Sesion
    {
        private static int idUsuario;
        private static int idRol;
        private static string nombreUsuario;
        private static SqlConnection conxion;
        public static DataTable dtPermisos = new DataTable();
        public static DataTable dtmenu = new DataTable();


        public static bool tienePermiso(int form, int opcion)
        {
            if (dtPermisos.Select("idmenu='" + form.ToString() + "' and idpermiso = '" + opcion.ToString() + "' and idrol ='" + idRol.ToString() + "'").Count() > 0)
            {
                return true;
            }
            return false;
        }
        public static SqlConnection getConexion()
        {
            //SqlConnection conx = new SqlConnection(Galactus.Properties.Settings.Default.conexionGalactus);
            //if (conx.State == ConnectionState.Closed)
            //{
            //    conx.Open();
            //}
            //;
            //return conx;
            return Conexion.obtenerConexion(0);
        }
        public static int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public static int IdRol
        {
            get
            {
                return idRol;
            }

            set
            {
                idRol = value;
            }
        }

        public static string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }
    }
}
