using System;

namespace I09Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string acumulador = "*";

            Console.WriteLine("Ingrese altura del triángulo equilátero: ");
            _ = int.TryParse(Console.ReadLine(), out altura);

            while(altura<=0)
            {
                Console.WriteLine("Error. Reingrese altura del triángulo equilátero: ");
                _ = int.TryParse(Console.ReadLine(), out altura);
            }

            for(int i=altura; i>0; i--)
            {
                Console.Write("    ");

                for(int j = i-1; j>0; j--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(acumulador);

                acumulador += "**";
            }

        }
    }
}
