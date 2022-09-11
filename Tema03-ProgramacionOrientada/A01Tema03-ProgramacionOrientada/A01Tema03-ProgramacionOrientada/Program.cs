using System;
using Entidades;

namespace A01Tema03_ProgramacionOrientada
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor c1 = new Conductor("Mario");
            Conductor c2 = new Conductor("Juan");
            Conductor c3 = new Conductor("Pedro");

            c1.DefinirKmPorDia();
            c2.DefinirKmPorDia();
            c3.DefinirKmPorDia();

            Conductor[] conductores = new Conductor[3];
            conductores[0] = c1;
            conductores[1] = c2;
            conductores[2] = c3;

            Empresa emp = new Empresa(conductores);

            Console.WriteLine(emp.MostrarGanadorDeSemana());
            Console.WriteLine(emp.MostrarGanadorPorDia("Miercoles"));
            Console.WriteLine(emp.MostrarGanadorPorDia("Viernes"));
        }
    }
}
