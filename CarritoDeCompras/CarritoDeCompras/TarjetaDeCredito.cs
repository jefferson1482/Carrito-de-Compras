using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class TarjetaDeCredito: IMetodoDePago 
    /*
      Se implementa la interfaz IMetodo de pago que permite tener la opción de pagar con tarjeta de crédito,
      esto es para no involucrar a la clase base de datos y violar el principio de inversión de dependencias.
    */
    {
        public void Pagar(Carrito carrito)
        {

        }
    }
}
