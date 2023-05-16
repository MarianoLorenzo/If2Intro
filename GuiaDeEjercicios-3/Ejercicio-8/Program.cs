using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double litros, pago, importe;

            Console.WriteLine("Ingrese la cantidad de litros vendidos");
            litros = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si paga en efectivo o cero si paga con otro medio");
            pago = double.Parse(Console.ReadLine());

            if (litros <= 50)
                importe = litros * 25;
            else if (litros > 50 && litros <=200)
                importe = litros * 20;
            else if (litros > 200 && litros <= 500)
                importe = litros * 15;
            else 
                importe = litros * 10;

            if (pago == 1)
                importe = importe * 0.9;

            Console.WriteLine("El importe final es: $" + importe);                   
        }
    }
}
