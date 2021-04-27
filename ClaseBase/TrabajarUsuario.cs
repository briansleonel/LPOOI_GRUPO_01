using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClaseBase {

    public class TrabajarUsuario {

        public static DataTable listarRoles() {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
