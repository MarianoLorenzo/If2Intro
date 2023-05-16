using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            if (n % 5 == 0)
                Console.WriteLine("El número " + n + " es múltiplo de 5");
            else
                Console.WriteLine("El número " + n + " no es múltiplo de 5"); 
        }
    }
}
