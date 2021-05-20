using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Disposicion
    {
        private int dip_Codigo;

        public int Dip_Codigo
        {
            get { return dip_Codigo; }
            set { dip_Codigo = value; }
        }
        private String dip_Descripcion;

        public String Dip_Descripcion
        {
            get { return dip_Descripcion; }
            set { dip_Descripcion = value; }
        }
    }
}
