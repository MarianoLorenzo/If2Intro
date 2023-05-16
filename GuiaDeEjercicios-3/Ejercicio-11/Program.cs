using System;

namespace Ejercicio_11
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

            if (n1 < n2 && n2 < n3)
                Console.WriteLine("Ordenados de menor a mayor: " + n1 + ", " + n2 + ", " + n3);
            else if (n1 < n3 && n3 < n2)
                Console.WriteLine("Ordenados de menor a mayor: " + n1 + ", " + n3 + ", " + n2); 
            else if (n2 < n1 && n1 < n3)
                Console.WriteLine("Ordenados de menor a mayor: " + n2 + ", " + n1 + ", " + n3); 
            else if (n2 < n3 && n3 < n1)
                Console.WriteLine("Ordenados de menor a mayor: " + n2 + ", " + n3 + ", " + n1); 
            else if (n3 < n1 && n1 < n2)
                Console.WriteLine("Ordenados de menor a mayor: " + n3 + ", " + n1 + ", " + n2);
            else if (n3 < n2 && n2 < n1)
                Console.WriteLine("Ordenados de menor a mayor: " + n3 + ", " + n2 + ", " + n1);

        }
    }
}
