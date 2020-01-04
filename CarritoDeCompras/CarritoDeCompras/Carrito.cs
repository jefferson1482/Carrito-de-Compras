using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    /*Aquí se realiza el cuarto principio que es: PRINCIPIO DE INVERSIÓN DE DEPENDENCIAS, donde se crea una clase llamada Carrito
    con sus clases hijas (Tarjeta de crédito, Base de datos) además de 2 interfaces (Ipersistencia y Imetodo de pago) esto, con el fin de que 
    cuando se crean más metodos de pagos o más formas de almacenar la información, no tengamos que modificar todo el código porque está todo 
    relacionado.
    */
    public class Carrito
    {
        private IPersistencia persistencia;
        private IMetodoDePago metodoDePago;
        public Carrito(IPersistencia persistencia, IMetodoDePago metodoDePago)
        {

            this.persistencia = persistencia;
            this.metodoDePago = metodoDePago;
        }
        public void Compras(Carrito carrito)
        {
            this.persistencia.Guardar(carrito);
            this.metodoDePago.Pagar(carrito);
        }
    }
}
