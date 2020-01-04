using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class ProductoSinDescuento:Producto, IProducto

        /*Se implemente el tercer principio SUSTITUCIÓN DE LISKOV, donde se utiliza un método 
          de una clase en otra clase hija. Se utilizó una interface llamada IProducto donde se 
          sobre escribe el método de calcular descuento.
         */
    {
        public ProductoSinDescuento()
        {

        }

        public DateTime FechaInicioDescuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        public decimal CalcularDescuento()
        {
            return 100;
        }



        /*
        public int CalcularFechaDescuento()
        {
            TimeSpan timespan = DateTime.Today - this.FechaInicioDescuento;
            int dia = timespan.Days;
            int fecha = dia / 365;
            return fecha;
        }*/

    }
}
