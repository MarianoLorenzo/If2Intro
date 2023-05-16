using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            Console.WriteLine("Ingrese tres números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            if ((n1 + n2) > (n2 * n3))
                Console.WriteLine("La suma de los dos primeros números ingresados es mayor al producto del segundo con el tercero");
                
        }
    }
}
