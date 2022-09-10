using System;

namespace I08Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string acumuladorBase = "*";

            Console.WriteLine("Ingrese altura del triángulo rectángulo: ");
            _ = int.TryParse(Console.ReadLine(), out altura);

            while(altura<=0)
            {
                Console.WriteLine("Error. Reingrese altura del triángulo rectángulo: ");
                _ = int.TryParse(Console.ReadLine(), out altura);
            }

            for(int i = 0; i<altura; i++)
            {
                Console.WriteLine(acumuladorBase);
                acumuladorBase += "**";
            }
            
        }
    }
}
