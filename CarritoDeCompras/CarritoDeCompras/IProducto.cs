using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{

    /*PRINCIPIO DE SUSTITUCIÓN DE LISKOV*/
    public interface IProducto
    {
        decimal CalcularDescuento();//Metodo utilizado en las clases hijas de la clase Producto
        
    }
}
