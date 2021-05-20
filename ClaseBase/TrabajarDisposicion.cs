using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//base de datos
using System.Data;
using System.Data.SqlClient;
namespace ClaseBase
{
    public class TrabajarDisposicion
    {
        public static DataTable listarDisposicionSP()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarDisposicion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;


            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
