using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactus.Util.Mensajes
{
    class Mensajes
    {
        public const string NOMBRE_SOFT = "Galactus";
        public const string Modificar_FORM = "¿ Desea Modificar el registro ?";
        public const string CANCELAR_FORM = "¿ Desea cancelar ?";
        public const string GUARDAR_FORM = "¿ Desea guardar ?";
        public const string ANULAR_FORM = "¿ Desea anular ?";
        public const string SALIR_FORM = "¿ Desea salir ?";
        public const string CONFIRMACION_GUARDADO = "Registro Guardado !";
        public const string CONFIRMACION_ANULADO = "Registro anulado !";


        #region Titulos
        public const string BUSQUEDA_BODEGA = "Busqueda de Bodega";
        public const string BUSQUEDA_PRODUCTO = "Busqueda de Productos";
        public const string BUSQUEDA_EQUIVALENCIA = "Busqueda de Equivalencia";
        public const string BUSQUEDA_MARCA = "Busqueda de Marca";
        public const string BUSQUEDA_PRESENTACION = "Busqueda de Presentación";
        public const string BUSQUEDA_UNIDAD_MEDIDA = "Busqueda de Unidades de Medida";
        public const string BUSQUEDA_ROL = "Busqueda de Roles";
        public const string BUSQUEDA_USUARIOS = "Busqueda de Usuarios";
        public const string BUSQUEDA_EPS = "Busqueda eps";
        public const string BUSQUEDA_PACIENTE = "Busqueda Paciente";
        public const string BUSQUEDA_EMPRESA = "Busqueda Empresa";
        public const string BUSQUEDA_CONTRATO_EPS = "Busqueda contrato eps";
        public const string BUSQUEDA_AREA = "Busqueda area";

        #region "Historia Clinica"
        public const string BUSQUEDA_ORDENES_MEDICAS = "Busqueda Ordenes";
        #endregion


        #endregion
        public static void mensajeFaltaInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static bool preguntaGuardar()
        {
            return MessageBox.Show(Mensajes.GUARDAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static bool preguntaAnular()
        {
            return MessageBox.Show(Mensajes.ANULAR_FORM, Mensajes.NOMBRE_SOFT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
