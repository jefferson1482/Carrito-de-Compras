using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public interface IPersistencia //Se crea la interface para implementarla en la clase hija de Base de datos
    {
        public void Guardar(Carrito carrito);
    }
}
