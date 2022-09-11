using System;
using Entidades;

namespace I03Tema03_ProgramacionOrientada
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Gomez", "a10", "Juan");
            Estudiante e2 = new Estudiante("Perez", "a11", "Luis");
            Estudiante e3 = new Estudiante("Diaz", "a12", "Maria");

            e1.NotaPrimerParcial = 2;
            e1.NotaSegundoParcial = 6;

            e2.NotaPrimerParcial = 5;
            e2.NotaSegundoParcial = 8;

            e3.NotaPrimerParcial = 6;
            e3.NotaSegundoParcial = 9;

            e1.Mostrar();
            e2.Mostrar();
            e3.Mostrar();
        }
    }
}
