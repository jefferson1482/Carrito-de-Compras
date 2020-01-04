using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class CabeceraFactura
    {
        public CabeceraFactura()
        {
        }

        //Crear la clase cliente
        //public class MyProperty { get; set; }

        public Cliente ClienteCabecera { get; set; }
        public Empresa EmpresaCabecera { get; set; }

    }
}
