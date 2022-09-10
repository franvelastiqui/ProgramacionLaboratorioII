using System;

namespace I01Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0;
            int promedio;
            bool flag = false;

            Console.WriteLine("Ingrese 10 numeros enteros: ");

            for(int i=0; i<10; i++)
            {
                while(int.TryParse(Console.ReadLine(), out numero) == false || Validador.Validar(numero, -100, 100) == false)
                {
                    Console.WriteLine("Error. Reingrese 10 numeros enteros: ");
                }

                acumulador += numero;

                if (numero<minimo || flag == false)
                {
                    minimo = numero;
                }

                if (numero > maximo || flag == false)
                {
                    maximo = numero;
                }

                flag = true;

            }

            promedio = acumulador / 10;

            Console.WriteLine($"Mínimo = {minimo}\tMáximo = {maximo}\tPromedio = {promedio}");
        }
    }
}
