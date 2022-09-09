using System;

namespace I01Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double max = 0;
            double min = 0;
            double sumaDeNumeros = 0;
            double promedio;
            bool flag;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                flag = double.TryParse(Console.ReadLine(), out numero);

                while (flag == false)
                {
                    Console.WriteLine("Error. Ingrese un numero válido: ");

                    flag = double.TryParse(Console.ReadLine(), out numero);
                }

                if (i == 0 || max < numero)
                {
                    max = numero;
                }

                if (i == 0 || min > numero)
                {
                    min = numero;
                }

                sumaDeNumeros += numero;
            }

            promedio = sumaDeNumeros / 5;

            Console.WriteLine("El máximo es {0}, el minimo es {1} y el promedio es {2}", max, min, promedio);
        }
    }
}
