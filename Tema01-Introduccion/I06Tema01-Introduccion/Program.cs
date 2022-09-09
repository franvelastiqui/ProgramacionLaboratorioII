using System;

namespace I06Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int añoInicial;
            int añoFinal;
            bool flag;
            bool esBisiesto;

            Console.WriteLine("Ingrese un año inicial: ");
            flag = int.TryParse(Console.ReadLine(), out añoInicial);
            while(flag == false)
            {
                Console.WriteLine("Error, reingrese un año inicial: ");
                flag = int.TryParse(Console.ReadLine(), out añoInicial);
            }

            Console.WriteLine("Ingrese un año final: ");
            flag = int.TryParse(Console.ReadLine(), out añoFinal);
            while (flag == false)
            {
                Console.WriteLine("Error, reingrese un año final: ");
                flag = int.TryParse(Console.ReadLine(), out añoFinal);
            }

            for(int i = añoInicial; i<=añoFinal; i++)
            {
                if(i % 4 == 0 && i % 100 != 0)
                {
                    esBisiesto = true;
                }
                else if(i % 4 == 0 && i % 400 == 0)
                {
                    esBisiesto = true;
                }
                else
                {
                    esBisiesto = false;
                }

                if(esBisiesto == true)
                {
                    Console.WriteLine($"Año {i} es bisiesto");
                }
            }
        }
    }
}
