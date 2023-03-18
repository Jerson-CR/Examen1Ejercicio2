using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int solNorteSurEntradas = 0;
            int solNorteSurAcumulado = 0;
            int sombraEsteOesteEntradas = 0;    
            int sombraEsteOesteAcumulado = 0;
            int preferencialEntradas = 0;
            int preferencialAcumulado = 0;

            while (true)
            {
                Console.WriteLine("Ingrese los datos de la venta: ");
                Console.WriteLine("Numero de factura: "); string factura = Console.ReadLine();
                Console.WriteLine("Cedula: "); string cedula = Console.ReadLine();
                Console.WriteLine("Nombre del comprador: "); string nombre = Console.ReadLine();
                Console.WriteLine("Localidad (1-Sol Norte/Sur, 2-Sombre Este/Oeste, 3-Preferencial)"); int localidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de entradas: "); int cantidad = int.Parse(Console.ReadLine());

                if (cantidad > 4)
                {
                    Console.WriteLine("Error solo se permiten maximo 4 entradas por cliente porfavor intente de nuevo");
                    break;

                }


                int precioEntrada = 0;
                string nombreLocalidad = "";

                switch (localidad)
                {
                    case 1:
                        precioEntrada = 10500;
                        nombreLocalidad = "Sol Norte/Sur";
                        solNorteSurEntradas += cantidad;
                        solNorteSurAcumulado += cantidad * precioEntrada;
                        break;
                    case 2:
                        precioEntrada = 20500;
                        nombreLocalidad = "Sombra Este/Oeste";
                        sombraEsteOesteEntradas += cantidad;
                        sombraEsteOesteAcumulado += cantidad * precioEntrada;
                        break;
                    case 3:
                        precioEntrada = 25500;
                        nombreLocalidad = "Preferencial";
                        preferencialEntradas += cantidad;
                        preferencialAcumulado += cantidad * precioEntrada;
                        break;
                    default:
                        break;
                }

                int subtotal = cantidad * precioEntrada;
                int cargosPorServicios = cantidad * 1000;
                int total = subtotal + cargosPorServicios;

                Console.WriteLine($"Número de factura: {factura}");
                Console.WriteLine($"Cédula: {cedula}");
                Console.WriteLine($"Nombre del comprador: {nombre}");
                Console.WriteLine($"Localidad: {nombreLocalidad}");
                Console.WriteLine($"Cantidad de entradas: {cantidad}");
                Console.WriteLine($"Subtotal: {subtotal}");
                Console.WriteLine($"Cargos por servicios: {cargosPorServicios}");
                Console.WriteLine($"Total a pagar: {total}");

                Console.Write("¿Desea ingresar otra venta? (s/n): "); string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "n")
                {
                    break;
                }

            }
            Console.WriteLine("Estadisticas:");
            Console.WriteLine($"Cantidad Entradas Localidad Sol Norte/Sur: {solNorteSurEntradas}");
            Console.WriteLine($"Acumulado Dinero Localidad Sol Norte/Sur: {solNorteSurAcumulado}");

            Console.WriteLine($"Cantidad Entradas Localidad Sombra Este/Oeste: {sombraEsteOesteEntradas}");
            Console.WriteLine($"Acumulado Dinero Localidad Sombra Este/Oeste: {sombraEsteOesteAcumulado}");

            Console.WriteLine($"Cantidad Entradas Localidad Preferencial: {preferencialEntradas}");
            Console.WriteLine($"Acumulado Dinero Localidad Preferencial: {preferencialAcumulado}");

            Console.ReadLine();
        }
    }
}
