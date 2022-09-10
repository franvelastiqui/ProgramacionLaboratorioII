using System;

namespace A01Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool flag;

            Console.WriteLine("Ingrese un número: ");

            flag = int.TryParse(Console.ReadLine(), out numero);

            while(flag == false || numero<0)
            {
                Console.WriteLine("Error. Reingrese un número: ");
                flag = int.TryParse(Console.ReadLine(), out numero);
            }

            if(numero>0)
            {
                Console.WriteLine($"El factorial de {numero} es {CalcularFactorial(numero)}");
            }
            else
            {
                Console.WriteLine("El factorial de 0 es 1");
            }
        }

        public static int CalcularFactorial(int numeroIngresado)
        {
            int acumulador = 1;

            for (int i = numeroIngresado; i > 0; i--)
            {
                acumulador *= i;
            }

            return acumulador;
        }
    }
}
