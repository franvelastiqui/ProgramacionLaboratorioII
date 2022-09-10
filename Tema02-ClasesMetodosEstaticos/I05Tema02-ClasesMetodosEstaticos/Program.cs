using System;

namespace I05Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un número entero: ");

            while(int.TryParse(Console.ReadLine(), out numero) == false)
            {
                Console.WriteLine("Error. Reingrese un número entero: ");
            }

            Console.WriteLine(Tabla.DevolverTabla(numero));
        }
    }
}
