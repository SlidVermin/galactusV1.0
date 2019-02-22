﻿using Galactus.Util.Constantes;
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
        public const string PARAMETROS_CONSULTAR_DESCRIPCION = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametroDescripcion]";

        public const String GENERAL_CONFIGURACION_PROCEDIMIENTOS_MEDICOS_BUSCAR = ConstanteGeneral.ESQUEMA_GENERAL + "[uspConfiguracionProcedimientosMedicosBuscar]";
       
        //public const String PARAMETROS_LISTAR_DOCUMENTOS = ConstanteGeneral.ESQUEMA_PARAMETRO + "[uspParametrosBuscarDocumentos]";
        #endregion
        #region SEGURIDAD
        public const String ROL_BUSCAR = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioRolBuscar]";
        public const String USUARIO_BUSCAR = ConstanteGeneral.ESQUEMA_SEGURIDAD + "[uspUsuarioBuscar]";
        #endregion
        #region UBICACION
        public const String CARGARPAIS = ConstanteGeneral.ESQUEMA_ADMISION + "uspPaisCargar";
        public const String CARGAR_DEPARTAMENTO = ConstanteGeneral.ESQUEMA_ADMISION + "uspDepartamentoCargar";
        public const String CARGAR_MUNICIPIO = ConstanteGeneral.ESQUEMA_ADMISION + "uspMunicipioCargar";
        public const String CARGAR_TIPO_DOCUMENTOS = ConstanteGeneral.ESQUEMA_ADMISION + "uspTipoDocumentosBuscar";
        public const String CARGAR_GENERO = ConstanteGeneral.ESQUEMA_ADMISION + "uspGeneroBuscar";
        public const String CARGAR_ESTADO_CIVIL = ConstanteGeneral.ESQUEMA_ADMISION + "uspEstadoCivilBuscar";
        public const String CARGAR_REGIMEN = ConstanteGeneral.ESQUEMA_ADMISION + "uspRegimenCargar";
        public const String CARGAR_AFILIACION = ConstanteGeneral.ESQUEMA_ADMISION + "uspAfiliacionCargar";
        public const String CARGAR_ZONA = ConstanteGeneral.ESQUEMA_ADMISION + "uspZonaCargar";
        public const String CARGAR_ESTRATO_SOCIAL = ConstanteGeneral.ESQUEMA_ADMISION + "uspEstratoSocialCargar";
        public const String CARGAR_EPS = ConstanteGeneral.ESQUEMA_ADMISION + "uspEpsBuscar";
        public const String PACIENTE_CREAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteCrear";
        public const String PACIENTE_BUSCAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteBuscar";
        public const String PACIENTE_CARGAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteCargar";
        public const String UBICACION_GEOGRAFICA = ConstanteGeneral.ESQUEMA_ADMISION + "uspUbicacionGeografica";
        public const String PACIENTE_ANULAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspPacienteAnular";

        public const String ADMISION_PACIENTE_CARGAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionPacienteCargar";
        public const String ADMISION_PACIENTE_BUSCAR = ConstanteGeneral.ESQUEMA_ADMISION + "uspAdmisionPacienteBuscar";
        #endregion
        #region Gestion
        public const string BUSCAR_TERCERO = ConstanteGeneral.ESQUEMA_TERCERO + "[uspTerceroBuscar]";
        public const string BUSCAR_TERCERO_CLIENTE = ConstanteGeneral.ESQUEMA_TERCERO + "[uspTerceroClienteBuscar]";
        public const string CREAR_CLIENTE = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspClienteCrear]";
        public const string BUSCAR_CLIENTE = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspClienteBuscar]";
        public const string ANULAR_CLIENTE = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspClienteAnular]";

        public const string BUSCAR_TERCERO_PROVEEDOR = ConstanteGeneral.ESQUEMA_TERCERO + "[uspTerceroProveedorBuscar]";
        public const string CREAR_PROVEEDOR = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspProveedorCrear]";
        public const string BUSCAR_PROVEEDOR = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspProveedorBuscar]";
        public const string ANULAR_PROVEEDOR = ConstanteGeneral.ESQUEMA_CLIENTE + "[uspProveedorAnular]";
        #endregion
    }
}
