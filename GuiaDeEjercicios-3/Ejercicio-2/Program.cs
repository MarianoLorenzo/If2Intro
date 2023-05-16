using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado;

            Console.WriteLine("Ingrese dos números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                resultado = n1 - n2;
                Console.WriteLine("El resultado de la resta es: " + resultado);
            }
            else if (n1 == n2)
            {
                resultado = n1 + n2;
                Console.WriteLine("El resultado de la suma es: " + resultado);
            }
            else 
            {
                resultado = n1 * n2;
                Console.WriteLine("El resultado de la multiplicación es: " + resultado);
            }
                
        }
    }
}
