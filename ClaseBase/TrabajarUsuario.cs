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
            cmd.CommandText += "usu_apellidoNombre AS 'Apellido y Nombre', ";
            cmd.CommandText += "rol_descripcion AS 'Rol', ";
            cmd.CommandText += "U.rol_codigo AS 'ID Rol' ";
            cmd.CommandText += "FROM Usuario AS U ";
            cmd.CommandText += "LEFT JOIN Rol AS R ON (R.rol_codigo = U.rol_codigo)";

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
            cmd.CommandText += "usu_apellidoNombre AS 'Apellido y Nombre', ";
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

        public static void updateUsuario(Usuario user) { 
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario ";
            cmd.CommandText += " SET usu_nombreUsuario = @username,  usu_password = @password,";
            cmd.CommandText += " usu_apellidoNombre = @apellidoNombre, rol_codigo = @rol ";
            cmd.CommandText += " WHERE usu_id = @id ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@username", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@password", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellidoNombre", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@id", user.Usu_ID);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        public static void updateUsuariosinpassword(Usuario user)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario ";
            cmd.CommandText += " SET usu_nombreUsuario = @username, ";
            cmd.CommandText += " usu_apellidoNombre = @apellidoNombre, rol_codigo = @rol ";
            cmd.CommandText += " WHERE usu_id = @id ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@username", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@apellidoNombre", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@id", user.Usu_ID);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void deleteUsuarioByID(int id) {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario ";
            cmd.CommandText += " WHERE usu_id = @id";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@id", id);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public static DataTable findUsuarioByUsername(string username) {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();

            
            cmd.CommandText = "SELECT * ";
            cmd.CommandText += " FROM Usuario AS U ";

            cmd.CommandText += " LEFT JOIN Rol AS R ON (R.rol_codigo = U.rol_codigo) ";

            cmd.CommandText += " WHERE U.usu_nombreUsuario = @username ";
            
            /*
            cmd.CommandText = "SELECT usu_id, usu_nombreUsuario, ";
            cmd.CommandText += "usu_password, usu_apellidoNombre, ";
            cmd.CommandText += "U.rol_codigo, rol_descripcion ";

            cmd.CommandText += " FROM Usuario AS U, Rol AS R ";
            cmd.CommandText += " WHERE usu_nombreUsuario = @username ";

            cmd.CommandText += "LEFT JOIN Rol AS R ON (R.rol_codigo = U.rol_codigo) "; */

            /*
            cmd.CommandText += "usu_nombreUsuario AS 'Username', ";
            cmd.CommandText += "usu_password AS 'Contraseña', ";
            cmd.CommandText += "usu_apellidoNombre AS 'Apellido y nombre', ";
            cmd.CommandText += "rol_descripcion AS 'Rol', ";
            cmd.CommandText += "U.rol_codigo AS 'ID Rol' ";
            cmd.CommandText += "FROM Usuario AS U ";
            cmd.CommandText += "LEFT JOIN Rol AS R ON (R.rol_codigo = U.rol_codigo) ";
             */

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@username", username);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
