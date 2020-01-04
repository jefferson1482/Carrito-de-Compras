using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{

    /* En este proyecto no existe el segundo principio OPEN/CLOSED, ya que no existe ningún método en el que se
     agreguen más funcionalidades, las clases y métodos están relacionadas entre sì. Aunque, existe una solución al principio 
     open/closed que es a traves del POLIMORFISMO
     */
    public class Factura
    {
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {
            this.Detalle = new List<DetalleFactura>();
        }

        public CabeceraFactura Cabecera { get; set; }

        //Detalle de carrito
        public List<DetalleFactura> Detalle { get; set; }


        public void CalcularSubtotal()
        {
            decimal subtotal = 0;
            foreach (DetalleFactura item in this.Detalle)
            {
                subtotal = subtotal + (item.Cantidad * item.ProductoCarrito.Precio);
            }

            this.SubTotal = subtotal;
        }

        public void CalcularDescuento()
        {
            if (this.SubTotal > 100)
            {
                this.Descuento = this.SubTotal * 0.05M;
            }
            else
            {
                this.Descuento = 0;
            }
        }

        public void CalcularTotal()
        {
            this.Total = this.SubTotal - this.Descuento;
        }

    }
}
