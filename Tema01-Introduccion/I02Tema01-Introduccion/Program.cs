using System;

namespace I02Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
			double numero;
			double cuadrado;
			double cubo;
			bool flag;

			Console.WriteLine("Ingrese un numero: ");
			flag = double.TryParse(Console.ReadLine(), out numero);

			while (numero <= 0)
			{
				Console.WriteLine("ERROR. ¡Reingresar número!");
				flag = double.TryParse(Console.ReadLine(), out numero);
			}

			cuadrado = Math.Pow(numero, 2);
			cubo = Math.Pow(numero, 3);
			Console.WriteLine("El cuadrado es {0} y el cubo es {1}", cuadrado, cubo);
		}
    }
}
