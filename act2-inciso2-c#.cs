using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;

        Console.Write("Ingrese la calificación: ");
        nota = Convert.ToDouble(Console.ReadLine());

        if (nota < 60)
        {
            Console.WriteLine("Deficiente");
        }
        else if (nota < 70)
        {
            Console.WriteLine("Regular");
        }
        else if (nota < 80)
        {
            Console.WriteLine("Bien");
        }
        else if (nota < 90)
        {
            Console.WriteLine("Muy bien");
        }
        else
        {
            Console.WriteLine("Excelente");
        }

        Console.ReadKey();
    
        }
    }
}
