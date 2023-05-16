using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;

            Console.WriteLine("Ingrese la longitud de los tres lados de un triángulo");
            lado1 = double.Parse(Console.ReadLine());
            lado2 = double.Parse(Console.ReadLine());
            lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado1 == lado3)
                Console.WriteLine("El triángulo es equilátero");
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                Console.WriteLine("El triángulo es isósceles");   
            else 
                Console.WriteLine("El triángulo es escaleno");  
        }
    }
}
