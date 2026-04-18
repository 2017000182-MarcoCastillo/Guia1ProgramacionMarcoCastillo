using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes;

            Console.Write("Ingrese el día: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el mes (1-12): ");
            mes = Convert.ToInt32(Console.ReadLine());

            if ((mes == 12 && dia >= 21) || mes == 1 || mes == 2 || (mes == 3 && dia < 21))
            {
                Console.WriteLine("Invierno");
            }
            else if ((mes == 3 && dia >= 21) || mes == 4 || mes == 5 || (mes == 6 && dia < 21))
            {
                Console.WriteLine("Primavera");
            }
            else if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 || (mes == 9 && dia < 23))
            {
                Console.WriteLine("Verano");
            }
            else
            {
                Console.WriteLine("Otoño");
            }

            Console.ReadKey();
        }
    }
}
