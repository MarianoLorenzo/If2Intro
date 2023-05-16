using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, memoria, extension, monto;

            Console.WriteLine("Ingrese 1 para el procesador i5, 2 para el i7 o 3 para el i9");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 para 8 RAM de memoria, 2 para 16 RAM o 3 para 32 RAM");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 para extender el disco a 1 TB o 0 para no extender");
            extension = int.Parse(Console.ReadLine());

            switch (procesador)
            {
                case 1:
                    switch (memoria)
                    {
                        case 1:
                            monto = 800;
                            break;
                        case 2:
                            monto = 900;
                            break;                              
                        default:
                            monto = 1000;
                            break;
                    }
                    break;
                case 2:
                    switch (memoria)
                    {
                        case 1:
                            monto = 900;
                            break;
                        case 2:
                            monto = 1000;
                            break;                              
                        default:
                            monto = 1400;
                            break;
                    }
                    break;
                default:
                    switch (memoria)
                    {
                        case 1:
                            monto = 1200;
                            break;
                        case 2:
                            monto = 1400;
                            break;                              
                        default:
                            monto = 2000;
                            break;
                    }
                    break;
            }

            if (extension == 1)
                monto = monto + 300;

            Console.WriteLine("El monto de la máquina seleccionada es: USD" + monto);

        }
    }
}
