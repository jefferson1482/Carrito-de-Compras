using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class ProductoConDescuento : Producto, IProducto, IProductoEnOferta
    /*Esta interfaz se la incluye en esta porque solo los productos que están con descuentos, cuentan con productos en oferta,
     en la clase productos sin descuentos, cumple con el cuarto SEGREGACIÓN DE INTERFACES.

     Se implemente el tercer principio SUSTITUCIÓN DE LISKOV, donde se utiliza un método de una clase en otra clase hija.
     Se utilizó una interface llamada IProducto donde se sobre escribe el método de calcular descuento.
     */
    {
        public ProductoConDescuento()
        {
            
        }

        public decimal Descuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        public  decimal CalcularDescuento()
        {
            return this.Precio * (this.Descuento / 100);
        }

        public int ObtenerProductoEnOferta()
        {
            throw new NotImplementedException();
        }

    }
}
