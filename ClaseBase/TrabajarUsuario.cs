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

        public static void addUsuario(Usuario user) {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_nombreUsuario, usu_password, usu_apellidoNombre, rol_codigo) values (@username, @password, @apellidoNombre, @rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@username", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@password", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellidoNombre", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static DataTable listarUsuarios() {

            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "usu_id AS 'ID', ";
            cmd.CommandText += "usu_nombreUsuario AS 'Username', ";
            cmd.CommandText += "usu_password AS 'Contraseña', ";
            cmd.CommandText += "usu_apellidoNombre AS 'Apellido y nombre', ";
            cmd.CommandText += "rol_descripcion AS 'Rol', ";
            cmd.CommandText += "U.rol_codigo AS 'ID Rol' ";
            cmd.CommandText += "FROM Usuario AS U ";
            cmd.CommandText += "LEFT JOIN Rol AS R ON (R.rol_codigo = U.rol_codigo)";
            /*
            cmd.CommandText += "rol_descripcion AS 'Rol', ";
            cmd.CommandText += "usu_apellidoNombre AS 'Apellido y nombre', ";
            cmd.CommandText += "usu_nombreUsuario AS 'Username', ";
            cmd.CommandText += "usu_password AS 'Contraseña', ";
            cmd.CommandText += "usu_id, U.rol_codigo ";
            cmd.CommandText += "FROM Usuario AS U ";
            cmd.CommandText += "LEFT JOIN Rol AS R ON (R.rol_codigo = U.rol_codigo)";
             * */

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarUsuarios(string sPattern) {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "usu_id AS 'ID', ";
            cmd.CommandText += "usu_nombreUsuario AS 'Username', ";
            cmd.CommandText += "usu_password AS 'Contraseña', ";
            cmd.CommandText += "usu_apellidoNombre AS 'Apellido y nombre', ";
            cmd.CommandText += "rol_descripcion AS 'Rol', ";
            cmd.CommandText += "U.rol_codigo AS 'ID Rol' ";
            cmd.CommandText += "FROM Usuario AS U ";
            cmd.CommandText += "LEFT JOIN Rol AS R ON (R.rol_codigo = U.rol_codigo) ";

            cmd.CommandText += "WHERE ";
            cmd.CommandText += "usu_nombreUsuario LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@pattern", "%"+sPattern+"%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
