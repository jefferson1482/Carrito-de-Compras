using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    /*
    Se cumple el cuarto principio de SEGREGACIÓN DE INTERFACES se tiene la clase padre (PRODUCTO) 
    y las clases hijas (PRODUCTO CON DESCUENTO y PRODUCTO SIN DESCUENTO) y se quiere agregar en los productos 
    con descuento una nueva funcionalidad de productos en oferta, para ello se crea una interfaz PRODUCTO EN OFERTA 
    para implementarlo en la clase productos con descuento.
    */
    interface IProductoEnOferta
    {
        int ObtenerProductoEnOferta();
    }
}
