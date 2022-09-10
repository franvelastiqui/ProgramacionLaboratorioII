using System;

namespace I07Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseT;
            double altura;
            double hipotenusa;

            Console.Write("Base del triángulo: ");
            baseT = double.Parse(Console.ReadLine());

            Console.Write("\nAltura del triángulo: ");
            altura = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(baseT,2)+Math.Pow(altura,2));

            Console.WriteLine($"El valor de la hiótenusa es {hipotenusa}");
        }
    }
}
