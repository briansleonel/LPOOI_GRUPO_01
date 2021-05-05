using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClaseBase
{
    public class TrabajarDepartamento
    {

        public static DataTable listarDepartamentos()
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM departamento";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarDepartamentobyIdEdificio(int id)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "dpto_codigo AS 'ID', ";
            cmd.CommandText += "edif_codigo AS 'Tipo', ";
            cmd.CommandText += "dpto_numero AS 'Numero', ";
            cmd.CommandText += "dpto_piso AS 'Piso', ";
            cmd.CommandText += "dpto_ambientes AS 'Ambientes', ";
            cmd.CommandText += "dpto_dormitorios AS 'Dormitorios', ";
            cmd.CommandText += "dpto_banios AS 'Banios', ";
            cmd.CommandText += "dpto_disposicion AS 'Disposicion', ";
            cmd.CommandText += "dpto_precio AS 'Precio' ";
            cmd.CommandText += "FROM Departamento AS D ";
            //cmd.CommandText += "LEFT JOIN Edificio AS E ON (E.edif_codigo = D.edif_codigo) ";

            cmd.CommandText += "WHERE ";
            cmd.CommandText += "edif_codigo LIKE @id ";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        
    }
}
