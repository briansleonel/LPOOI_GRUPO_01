﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClaseBase
{
    public class TrabajarTipoDepartamento
    {
        public static DataTable listarTipoDepartamento()
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM TipoDepartamento";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
