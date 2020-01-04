using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class DetalleFactura
    {
        public DetalleFactura()
        {
        }

        public Producto ProductoCarrito { get; set; }

        public int Cantidad { get; set; }

    }
}
