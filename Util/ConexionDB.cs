﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Data;

public class ConexionDB
{
    public static string cadenaConexionDefault = "Data Source=25.132.197.172;Initial Catalog=Galactus_HC;persist Security Info=True;User ID = galactus_main;Password=galactus_main;MultipleActiveResultSets=True";
    public static SqlConnection conn = new SqlConnection(cadenaConexionDefault);

    public enum enlace
    {
        DEFAULT = 0,
    }

    public static SqlConnection obtenerConexion(enlace enlace)
    {
        string cadenaConexion = obtenerCadenaConexion(enlace);
        if (conn.State != ConnectionState.Open)
        {
            conn.Dispose();
            conn = new SqlConnection(cadenaConexion);
            conn.Open();
        }

        return conn;
    }

    public static SqlConnection obtenerNuevaConexion(enlace enlace)
    {
        string cadenaConexion = obtenerCadenaConexion(enlace);
        return new SqlConnection(cadenaConexion);
    }

    public static String obtenerCadenaConexion(enlace enlace)
    {
        Hashtable conexiones = new Hashtable();
        conexiones.Add(enlace.DEFAULT, cadenaConexionDefault);

        return (String)conexiones[enlace];
    }
}