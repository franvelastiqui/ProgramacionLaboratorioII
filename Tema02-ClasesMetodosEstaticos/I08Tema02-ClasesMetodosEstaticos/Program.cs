using System;

namespace I08Tema02_ClasesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            int acumuladorDias = 0;
            DateTime fechaActual = new DateTime();

            Console.WriteLine("Ingrese su fecha de nacimiento (dia, mes año): ");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            año = int.Parse(Console.ReadLine());

            DateTime fechaIngresada = new DateTime(año, mes, dia);

            fechaActual = DateTime.Now;

            for(int i = fechaIngresada.Year; i<=fechaActual.Year; i++)
            {
                for(int j = 1; j<=12; j++)
                {
                    acumuladorDias += DateTime.DaysInMonth(i, j);
                }

                if(i == fechaIngresada.Year)
                {
                    for(int j = 1; j < fechaIngresada.Month; j++)
                    {
                        acumuladorDias -= DateTime.DaysInMonth(i, j);
                    }

                    acumuladorDias -= fechaIngresada.Day;
                }
                else if(i == fechaActual.Year)
                {
                    acumuladorDias -= (DateTime.DaysInMonth(i, fechaActual.Month) - fechaActual.Day);
                    for (int k = fechaActual.Month; k < 12; k++)
                    {
                        acumuladorDias -= DateTime.DaysInMonth(i, k);
                    }
                }
            }


            Console.WriteLine($"Pasaron {acumuladorDias} días");
        }
    }
}
