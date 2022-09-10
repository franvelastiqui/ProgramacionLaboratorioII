using System;

namespace I06Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Console.WriteLine("Elija el número correspondiente para calcular el área de:\n1.Cuadrado\n2.Triángulo\n3.Círculo");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    double lado;
                    Console.WriteLine("Ingrese el lado del cuadrado: ");
                    lado = double.Parse(Console.ReadLine());
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCuadrado(lado));
                    break;

                case "2":
                    double baseT;
                    double altura;
                    Console.WriteLine("Ingrese la base y luego la altura del triánglo: ");
                    baseT = double.Parse(Console.ReadLine());
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaTriangulo(baseT, altura));
                    break;

                case "3":
                    double radio;
                    Console.WriteLine("Ingrese el radio del círculo: ");
                    radio = double.Parse(Console.ReadLine());
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCirculo(radio));
                    break;
                default:
                    Console.WriteLine("Opcion no válida");
                    break;
            }
        }
    }
}
