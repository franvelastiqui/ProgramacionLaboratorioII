using System;

namespace I03Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numero;

            Console.WriteLine("Binario o decimal: ");
            respuesta = Console.ReadLine();

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if(respuesta == "b")
            {
                Console.WriteLine(Conversor.ConvertirBinarioADecimal(numero));
            }
            else
            {
                Console.WriteLine(Conversor.ConvertirDecimalABinario(numero));
            }

        }
    }
}
