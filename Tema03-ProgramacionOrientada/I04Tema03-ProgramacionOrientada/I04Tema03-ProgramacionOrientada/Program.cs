using System;
using Entidades;

namespace I04Tema03_ProgramacionOrientada
{
    class Program
    {
        static void Main(string[] args)
        {
            string gasto;
            int acumulador = 0;

            //Boligrafo azul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, 50);

            _ = rojo.Pintar(51, out gasto);
            Console.WriteLine($"La tinta es {rojo.Tinta}");
            Console.WriteLine(gasto);
            Console.WriteLine(acumulador);
            rojo.Recargar();
            Console.WriteLine($"La tinta es {rojo.Tinta}");
        }
    }
}
