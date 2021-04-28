using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Usuario
    {
        private int usu_ID;
        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        
        private string usu_NombreUsuario;
        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        
        private string usu_Contraseña;
        public string Usu_Contraseña
        {
            get { return usu_Contraseña; }
            set { usu_Contraseña = value; }
        }
        
        private string usu_ApellidoNombre;
        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        
        private int rol_Codigo;
        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="id"></param>
        /// <param name="apellidoNombre"></param>
        /// <param name="rol"></param>
        public Usuario(string nombreUsuario,  string contrasenia,
                       int id, string apellidoNombre,int rol)
        {
            Usu_NombreUsuario = nombreUsuario;
            Usu_Contraseña = contrasenia;
            Usu_ID = id;
            Usu_ApellidoNombre = apellidoNombre;
            Rol_Codigo = rol;
        }

        public Usuario() {
            // TODO: Complete member initialization
        }
    }
}
