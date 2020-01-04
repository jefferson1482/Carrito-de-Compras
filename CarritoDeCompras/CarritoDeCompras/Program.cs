﻿using System;

namespace CarritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            StockProductos stock = new StockProductos();
            stock.CrearProductos();
            stock.ImprimirStockProductos();


            ClienteSinRegistro cliente = new ClienteSinRegistro();
            cliente.Apellidos = "Zambrano Zambrano";
            cliente.Nombres = "Michael Jackson";
            cliente.Email = "michael@web.com";
            cliente.Cedula = "1112223334";
            cliente.Contrasena = "mzambrano";

            Empresa empresa = new Empresa();
            empresa.RazonSocial = "Amazon";
            empresa.Direccion = "California";

            CabeceraFactura cabeceraCarrito = new CabeceraFactura();
            cabeceraCarrito.ClienteCabecera = cliente;
            cabeceraCarrito.EmpresaCabecera = empresa;

            Factura factura = new Factura();

            factura.Cabecera = cabeceraCarrito;
            string opcion;
            int codigo;
            do
            {
                Console.WriteLine("Ingrese el codigo del producto");
                codigo = int.Parse(Console.ReadLine());
                DetalleFactura detalleCarrito = new DetalleFactura();
                detalleCarrito.ProductoCarrito = stock.ListaStockProductos[codigo - 1];
                Console.WriteLine("Ingrese la cantidad del producto elegido:");
                detalleCarrito.Cantidad = int.Parse(Console.ReadLine());
                factura.Detalle.Add(detalleCarrito);
                Console.WriteLine("Escriba A para seguir agregando productoso S para salir");
                opcion = Console.ReadLine();
            } while (opcion != "S");

            //IMPRIMIR POR PANTALLA EL NOMBRE DEL PRODUCTO, SU PRECIO Y LA CANTIDAD
            Console.WriteLine("Productos facturados");
            Console.WriteLine("Descripcion\tPrecio\tCantidad");

            foreach (var item in factura.Detalle)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    item.ProductoCarrito.Descripcion, item.ProductoCarrito.Precio, item.Cantidad);
            }


            Console.WriteLine();

            /*
            var total = factura.Detalle.Sum(c => c.ProductoCarrito.Precio * c.Cantidad);
            Console.WriteLine();
            Console.WriteLine(total);
            */

            /*

            var resultado = factura.Detalle.Where(c => c.ProductoCarrito.Precio > 5).OrderBy(c => c.ProductoCarrito.Precio);
            foreach (var item in resultado)
            {

                Console.WriteLine("{0}\t\t{1}\t{2}",
                item.Identificador, item.Descripcion, item.Precio);

            }
            */

            factura.CalcularSubtotal();
            factura.CalcularDescuento();
            factura.CalcularTotal();

            Console.WriteLine(factura.SubTotal);
            Console.WriteLine(factura.Descuento);
            Console.WriteLine(factura.Total);


        }
    }
}
