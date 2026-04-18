using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("La persona es MAYOR de edad");
            }
            else
            {
                Console.WriteLine("La persona es MENOR de edad");
            }

            Console.ReadKey();
        }
    }
}
