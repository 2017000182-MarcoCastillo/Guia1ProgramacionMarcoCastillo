using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("=== BUZÓN DE VOZ ===");
            Console.WriteLine("1. Ventas");
            Console.WriteLine("2. Soporte técnico");
            Console.WriteLine("3. Atención al cliente");
            Console.WriteLine("4. Dejar un mensaje");
            Console.Write("Seleccione una opción (1-4): ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado VENTAS. Un asesor le atenderá.");
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado SOPORTE TÉCNICO. Espere en línea.");
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionado ATENCIÓN AL CLIENTE.");
                    break;
                case 4:
                    Console.WriteLine("Por favor, deje su mensaje después del tono.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
