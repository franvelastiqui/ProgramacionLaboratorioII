using System;

namespace I04Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int acumulador = 0;
            int contador = 0;

            do
            {
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acumulador += i;
                    }
                }

                if (numero == acumulador)
                {
                    Console.WriteLine(numero);
                    contador++;
                }

                numero += 1;
                acumulador = 0;
            } while (contador < 4);

            
        }
    }
}
