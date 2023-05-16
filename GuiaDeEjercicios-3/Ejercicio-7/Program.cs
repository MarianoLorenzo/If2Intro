using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            Console.WriteLine("Ingrese cuatro números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3 && n3 > n4)
                Console.WriteLine("Los números están ordenados de forma decreciente");
            else 
                Console.WriteLine("Los números NO están ordenados de forma decreciente");
        }
    }
}
