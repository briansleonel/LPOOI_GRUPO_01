using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Edificio
    {
        private int edif_Codigo;

        public int Edif_Codigo
        {
            get { return edif_Codigo; }
            set { edif_Codigo = value; }
        }
        private string edif_Nombre;

        public string Edif_Nombre
        {
            get { return edif_Nombre; }
            set { edif_Nombre = value; }
        }
        private string edif_Direccion;

        public string Edif_Direccion
        {
            get { return edif_Direccion; }
            set { edif_Direccion = value; }
        }
        private string edif_Administrador;

        public string Edif_Administrador
        {
            get { return edif_Administrador; }
            set { edif_Administrador = value; }
        }
        private string edif_Telefono;

        public string Edif_Telefono
        {
            get { return edif_Telefono; }
            set { edif_Telefono = value; }
        }
    }
}
