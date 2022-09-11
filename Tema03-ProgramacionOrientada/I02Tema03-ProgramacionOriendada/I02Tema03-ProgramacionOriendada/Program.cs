using System;
using Entidades;

namespace I02Tema03_ProgramacionOriendada
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaP1 = new DateTime(1998, 11, 6);
            Persona p1 = new Persona("Juan", fechaP1, 41585289);

            DateTime fechaP2 = new DateTime(1998, 7, 6);
            Persona p2 = new Persona("Pedro", fechaP2, 45236987);

            DateTime fechaP3 = new DateTime(2009, 7, 6);
            Persona p3 = new Persona("Carla", fechaP3, 47896321);

            Persona[] personas = new Persona[3];

            personas[0] = p1;
            personas[1] = p2;
            personas[2] = p3;

            for (int i = 0; i<3; i++)
            {
                if (String.Equals(personas[i].EsMayorDeEdad(), "Es mayor de edad"))
                {
                    Console.WriteLine(personas[i].Mostrar());
                }
            }
        }
    }
}
