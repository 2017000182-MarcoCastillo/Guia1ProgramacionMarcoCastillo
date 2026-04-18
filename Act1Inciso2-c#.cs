using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            double cal1, cal2, cal3, cal4, cal5, promedio;

        Console.Write("Ingrese la calificación 1: ");
        cal1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la calificación 2: ");
        cal2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la calificación 3: ");
        cal3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la calificación 4: ");
        cal4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la calificación 5: ");
        cal5 = Convert.ToDouble(Console.ReadLine());

        promedio = (cal1 + cal2 + cal3 + cal4 + cal5) / 5;

        Console.WriteLine("El promedio es: " + promedio);

        if (promedio >= 61)
        {
            Console.WriteLine("El alumno APRUEBA");
        }
        else
        {
            Console.WriteLine("El alumno REPRUEBA");
        }

        Console.ReadKey();
    
        }
    }
}
