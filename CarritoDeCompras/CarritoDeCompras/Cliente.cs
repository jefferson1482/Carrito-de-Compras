using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class Cliente
    {
        public Cliente()
        {
        }

        //PROPIEDADES
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }

    }
}
