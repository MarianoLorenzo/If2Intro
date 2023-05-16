using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double parcial1, parcial2;

            Console.WriteLine("Ingrese la nota del primer parcial");
            parcial1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo parcial");
            parcial2 = double.Parse(Console.ReadLine());

            if (parcial1 >= 8 && parcial2 >= 8)
                Console.WriteLine("Aprobación directa");
            else if (parcial1 >= 6 && parcial2 >= 6)
                Console.WriteLine("Rinde examen final");
            else 
                Console.WriteLine("Debe recuperar");             
        }
    }
}
