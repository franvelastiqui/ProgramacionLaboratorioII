using System;
using Entidades;

namespace A02Tema03_ProgramacionOrientada
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Juan", "Perez", "Mitre 34", "11345", 1);
            Cliente c2 = new Cliente("Maria", "Gonzalez", "Italia 9", "52640", 1);
            Cliente c3 = new Cliente("Mario", "Tani", "Juncal 98", "31694", 2);

            Mascota m1 = new Mascota("Chucho", 1998, "perro");
            Mascota m2 = new Mascota("Charles", 2005, "gato");
            Mascota m3 = new Mascota("Patacon", 2000, "perro");
            Mascota m33 = new Mascota("Olivia", 1995, "gato");

            m2.AgregarVacuna("Triple Felina");
            m3.AgregarVacuna("Rabia");

            _ = c1.AgregarMascota(m1);
            _ = c2.AgregarMascota(m2);
            _ = c3.AgregarMascota(m3);
            _ = c3.AgregarMascota(m33);

            Console.WriteLine(c1.MostrarDatos());
            Console.WriteLine(c2.MostrarDatos());
            Console.WriteLine(c3.MostrarDatos());
        }
    }
}
