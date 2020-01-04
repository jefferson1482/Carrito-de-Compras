using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
   public class Impresora
    {
        public Impresora()
        {
        }
        /*Aquí se realiza el primer principio RESPONSABILIDAD ÚNICA, que consiste en que un 
          objeto realice una sola cosa. Se crea una clase llamada impresora donde solo imprimira los datos del cliente , este metodo
          no se puede implementar en la clase Cliente
        */
        public void ImprimirDatosCliente(Cliente cliente)
        {

            Console.WriteLine(cliente.Apellidos + cliente.Nombres);

            //return cliente.Nombres + " " + cliente.Apellidos;

        }

    }
}
