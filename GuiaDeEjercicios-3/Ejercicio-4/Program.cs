using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double importeVenta, litros, importeFinal;

            Console.WriteLine("Ingrese el importe total de la venta");
            importeVenta = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendidos");
            litros = double.Parse(Console.ReadLine());

            if (litros <= 100)
                Console.WriteLine("El importe es: $" + importeVenta.ToString("0.00"));
            else if (litros > 100 && litros <= 300)
            {
                importeFinal = importeVenta * 0.9;
                Console.WriteLine("El importe es: $" + importeFinal.ToString("0.00"));
            }      
            else if (litros > 300 && litros <= 500)
            {
                importeFinal = importeVenta * 0.85;
                Console.WriteLine("El importe es: $" + importeFinal.ToString("0.00"));
            } 
            else 
            {
                importeFinal = importeVenta * 0.75;
                Console.WriteLine("El importe es: $" + importeFinal.ToString("0.00"));
            }
                
        }
    }
}
