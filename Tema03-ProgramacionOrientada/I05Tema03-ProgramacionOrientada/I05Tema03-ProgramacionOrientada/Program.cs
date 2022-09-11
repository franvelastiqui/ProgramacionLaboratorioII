using System;
using Geometria;

namespace I05Tema03_ProgramacionOrientada
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(-1, 2);
            Punto punto2 = new Punto(6, -1);

            Rectangulo miRectangulo = new Rectangulo(punto1, punto2);

            Mostrar(miRectangulo);
        }

        public static void Mostrar(Rectangulo figura)
        {
            Console.WriteLine($"Area: {figura.Area}\nPerimetro: {figura.Perimetro}");
        }
    }
}
