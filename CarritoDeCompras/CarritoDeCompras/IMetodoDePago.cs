using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public interface IMetodoDePago //Se crea la interfaz para implementarla en la clase hija de Tarjta de crédito
    {
        void Pagar(Carrito carrito);
    }
}
