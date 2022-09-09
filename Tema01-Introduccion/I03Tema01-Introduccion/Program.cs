using System;

namespace I03Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
			double numero;
			bool flag = true;
			bool esPrimo = true;
			string salida;

			Console.WriteLine("Ingrese un numero aquí");
			flag = double.TryParse(Console.ReadLine(), out numero);

			while (flag == false)
			{
				Console.WriteLine("ERROR: Reingrese un numero aquí o ingrese -salir-: ");

				salida = Console.ReadLine();

				if (salida == "salir")
				{
					Environment.Exit(0);
				}

				flag = double.TryParse(salida, out numero);
			}

			do
			{
				for (int i = 2; i < numero; i++)
				{
					if (numero % i == 0)
					{
						esPrimo = false;
					}
				}

				if (esPrimo == true)
				{
					Console.WriteLine(numero);
				}

				esPrimo = true;
				numero -= 1;
			}
			while (numero > 0);
		}
    }
}
