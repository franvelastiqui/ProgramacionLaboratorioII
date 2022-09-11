using System;
using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public int NotaPrimerParcial
        {
            set
            {
                this.notaPrimerParcial = value;
            }
        }

        public int NotaSegundoParcial
        {
            set
            {
                this.notaSegundoParcial = value;
            }
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial>=4 && notaSegundoParcial>=4)
            {
                return random.Next(6, 11);
            }
            return -1;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{nombre} {apellido}. {legajo}\nNota 1: {notaPrimerParcial}\tNota 2: {notaSegundoParcial}\nPromedio: {CalcularPromedio()}");

            if(CalcularNotaFinal() == -1)
            {
                sb.Append("\nAlumnos desaprobado\n");
            }
            else
            {
                sb.Append($"\nNota final: {CalcularNotaFinal()}\n");
            }

            Console.WriteLine(sb);
        }
    }
}
