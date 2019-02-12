using Galactus.Util.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus
{
    class Query
    {
        #region GENERALES 
        public const string SEG_AUTENTICACION = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspLoginValidar]";
        public const string SEG_ARMAR_MENU = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspMenuArmar]";
        public const string SEG_LLENAR_PERMISOS = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspMenuPermisosLlenar]";
        #endregion
        #region INVENTARIO 
        public const string ALMACEN_BUSCAR = ConstanteGeneral.ESQUEMA_ALMACEN  + "[uspBodegaBuscar]";
        public const string PRODUCTO_LISTAR_EQUIVALENCIA = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaListar]";
        public const string PRODUCTO_BUSCAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspProductoBuscar]";
        public const string PRODUCTO_CARGAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspProductoCargar]";

        public const string EQUIVALENCIA_BUSCAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaBuscar]";
        public const string EQUIVALENCIA_CARGAR = ConstanteGeneral.ESQUEMA_ALMACEN + "[uspEquivalenciaCargar]";
        #endregion
        #region ADMISIONES
        public const String MANUAL_SERVICIO_CREAR = "";
        public const String MANUAL_SERVICIO_BUSCAR = "";
        public const String MANUAL_SERVICIO_CARGAR_SOAT = "";
        public const String MANUAL_SERVICIO_CARGAR_ISS = "";
        public const String MANUAL_SERVICIO_CARGAR_CUPS = "";
        public const String MANUAL_SERVICIO_CONSULTAR_SOAT = "";
        public const String MANUAL_SERVICIO_CONSULTAR_ISS = "";
        public const String MANUAL_SERVICIO_CONSULTAR_CUPS = "";
       
        #endregion
        #region CONFIGURACIÓN 
        public const String PARAMETROS_CARGAR = ConstanteGeneral.ESQUEMA_PARAMETRO +  "[uspParametrosCargar]";
        public const String PARAMETROS_CARGAR_DOCUMENTOS = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametrosCargarDocumentos]";
        public const String PARAMETROS_LISTAR_DOCUMENTOS = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametrosBuscarDocumentos]";

        public const String GENERAL_CONFIGURACION_PROCEDIMIENTOS_MEDICOS_BUSCAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspConfiguracionProcedimientosMedicosBuscar]";
       
        //public const String PARAMETROS_LISTAR_DOCUMENTOS = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametrosBuscarDocumentos]";
        #endregion
        #region SEGURIDAD
        public const String ROL_BUSCAR = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[Seguridad].[uspEquivalenciaBuscar]";
        #endregion
        #region UBICACION
        public const String CARGARPAIS = ConstanteGeneral.ESQUEMA_ADMISION + "uspPaisCargar";
        public const String CARGAR_DEPARTAMENTO = ConstanteGeneral.ESQUEMA_ADMISION + "uspDepartamentoCargar";
        #endregion

    }
}
