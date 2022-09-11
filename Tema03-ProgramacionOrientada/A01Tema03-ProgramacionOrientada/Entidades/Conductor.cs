using System;

namespace Entidades
{
    public class Conductor
    {
        private string nombre;
        private double[] kmRecorridos;

        public Conductor(string nombre)
        {
            this.nombre = nombre;
            this.kmRecorridos = new double[7];
        }

        public string Nombre
        { 
            get { return this.nombre; }
        }
        public double[] KmRecorridos
        {
            get
            {
                return this.kmRecorridos;
            }
        }

        public void DefinirKmPorDia()
        {
            for(int i = 0; i<7; i++)
            {
                Console.WriteLine($"{Enum.GetName(typeof(Dias), i)}: ");
                this.kmRecorridos[i]=double.Parse(Console.ReadLine());
            }
        }
    }

    public enum Dias
    {
        Lunes = 0,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }
}
