using System;

namespace I04Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double primerNumero;
            double segundoNumero;
            char operador;

            Console.WriteLine("Ingrese dos números y un operador: ");
            primerNumero = double.Parse(Console.ReadLine());
            segundoNumero = double.Parse(Console.ReadLine());
            operador = char.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado = {Calculadora.Calcular(primerNumero, segundoNumero, operador)}");
        }
    }
}
