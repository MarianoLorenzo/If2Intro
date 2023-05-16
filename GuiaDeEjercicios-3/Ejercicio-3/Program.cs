using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado;

            Console.WriteLine("Ingrese dos números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            if (n2 != 0)
            {
                resultado = n1 / n2;
                Console.WriteLine("El resultado de la división es: " + resultado.ToString("0.00"));        
            }  
            else 
                Console.WriteLine("No se puede dividir por cero");  
        }
    }
}
