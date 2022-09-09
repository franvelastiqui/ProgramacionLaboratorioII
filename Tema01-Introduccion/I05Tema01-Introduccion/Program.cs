using System;

namespace I05Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumaMinimo = 0;
            int sumaMaximo = 0;
            bool flag;

            Console.WriteLine("Ingrese un numero: ");
            flag = int.TryParse(Console.ReadLine(), out numero);

            while (numero <= 0)
            {
                Console.WriteLine("Error, reingrese un numero mayor a 0: ");
                flag = int.TryParse(Console.ReadLine(), out numero);
            }

            for (int centro = 1; centro<numero; centro++)
            {
                for (int i = 1; i < centro; i++)
                {
                    sumaMinimo += i;
                }

                for (int j = centro + 1; j>centro; j++)
                {
                    if (sumaMinimo == sumaMaximo)
                    {
                        Console.WriteLine($"Numero: {centro}");
                        break;
                    }
                    else if(sumaMaximo >= sumaMinimo)
                    {
                        break;
                    }

                    sumaMaximo += j;
                }

                sumaMinimo = 0;
                sumaMaximo = 0;
            }

        }
    }
}
