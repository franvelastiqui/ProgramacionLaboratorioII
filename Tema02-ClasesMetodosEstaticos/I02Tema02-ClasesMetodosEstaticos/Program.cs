using System;

namespace I02Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un número entero: ");

                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("Error. Reingrese un número entero: ");
                }

                acumulador += numero;

                Console.WriteLine("¿Desea continuar? (S/N)");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));

            Console.WriteLine($"Numero final = {acumulador}");
        }
    }
}
