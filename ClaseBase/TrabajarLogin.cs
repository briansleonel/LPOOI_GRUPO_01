using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


namespace ClaseBase
{
    public class TrabajarLogin
    {
        public static bool login(string usuario, string pass)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario AS U LEFT OUTER JOIN Rol AS R ON (U.rol_codigo = R.rol_codigo) WHERE (usu_nombreUsuario = @usuario AND usu_password = @pass)";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@pass", pass);
           
            

            

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            
            

            conexion.Open();
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    UserLogin.usuLog_ID = reader.GetInt32(0);
                    UserLogin.usuLog_NombreUsuario = reader.GetString(1);
                    UserLogin.usuLog_FullName = reader.GetString(3);
                    UserLogin.rolLog_Codigo = reader.GetInt32(4);
                    UserLogin.rolLog_Descripcion = reader.GetString(6);
                    
                }
                return true;
            }
            else
                return false;
            
            cmd.ExecuteNonQuery();
            conexion.Close();

            DataTable dt = new DataTable();
           // da.Fill(dt);

            //return dt;
        }


        //public bool login(string usuario, string pass)
        //{
        //    using (var connection = GetConnection())
        //    {
        //        connection.Open();
        //        using (var cmd = new SqlCommand())
        //        {
        //            cmd.Connection = connection;
        //            cmd.CommandText = "select *from Users where LoginName=@usuario and Password=@pass";
        //            cmd.Parameters.AddWithValue("@usuario", usuario);
        //            cmd.Parameters.AddWithValue("@pass", pass);
        //            cmd.CommandType = CommandType.Text;
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    UserCache.IdUser = reader.GetInt32(0);
        //                    UserCache.LoginName = reader.GetString(1);
        //                    UserCache.Password = reader.GetString(2);
        //                    UserCache.FirstName = reader.GetString(3);
        //                    UserCache.LastName = reader.GetString(4);
        //                    UserCache.Position = reader.GetString(5);
        //                    UserCache.Email = reader.GetString(6);
        //                }
        //                return true;
        //            }
        //            else
        //                return false;
        //        }
        //    }
        //} 


    }
}
