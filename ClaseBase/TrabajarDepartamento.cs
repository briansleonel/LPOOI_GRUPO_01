using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
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
            cmd.CommandText = "SELECT * FROM edificioId";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
        public static DataTable listarDepartamentosSP()
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListaDepartamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listarDepartamentosPorSP(int valor)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "OrdenarDepartamentoPor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;
           
            cmd.Parameters.AddWithValue("@val", valor);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listarDepartamentosPorEdificcioORDireccionSP(String valor)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "OrdenarDepartamentoPorEdificioOrDireccion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@dato", valor);

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

        public static DataTable NuevoDepartamentoSP(Departamento depa)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "NuevoDepartamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@edif_codigo", depa.Edif_Codigo);
            cmd.Parameters.AddWithValue("@tipoDpto_codigo", depa.Dpto_Tipo);
            cmd.Parameters.AddWithValue("@numero", depa.Dpto_Numero);
            cmd.Parameters.AddWithValue("@piso", depa.Dpto_Piso);
            cmd.Parameters.AddWithValue("@ambiente", depa.Dpto_Ambientes);
            cmd.Parameters.AddWithValue("@dormitorios", depa.Dpto_Dormitorios);
            cmd.Parameters.AddWithValue("@banio", depa.Dpto_Baños);
            cmd.Parameters.AddWithValue("@disposicion", depa.Dpto_Disposicion);
            cmd.Parameters.AddWithValue("@precio", depa.Dpto_Precio);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable UpdateDepartamentoSP(Departamento depa)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UpdateDepartamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@edif_codigo", depa.Edif_Codigo);
            cmd.Parameters.AddWithValue("@tipoDpto_codigo", depa.Dpto_Tipo);
            cmd.Parameters.AddWithValue("@numero", depa.Dpto_Numero);
            cmd.Parameters.AddWithValue("@piso", depa.Dpto_Piso);
            cmd.Parameters.AddWithValue("@ambiente", depa.Dpto_Ambientes);
            cmd.Parameters.AddWithValue("@dormitorios", depa.Dpto_Dormitorios);
            cmd.Parameters.AddWithValue("@baños", depa.Dpto_Baños);
            cmd.Parameters.AddWithValue("@disposicion", depa.Dpto_Disposicion);
            cmd.Parameters.AddWithValue("@precio", depa.Dpto_Precio);
            cmd.Parameters.AddWithValue("@dpto_codigo", depa.Dpto_Codigo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable EliminarDepartamentobyIdSP(int departamento)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EliminarDepartamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@dpto_codigo", departamento);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
