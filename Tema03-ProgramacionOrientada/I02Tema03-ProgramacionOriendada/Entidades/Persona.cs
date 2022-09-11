using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.Nombre = nombre;
            this.FechaDeNacimiento = fechaDeNacimiento;
            this.Dni = dni;
        }

        public string Nombre
        { 
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        private int CalcularEdad()
        {
            int edad;

            edad = DateTime.Now.Year - this.FechaDeNacimiento.Year;

            if(this.FechaDeNacimiento.Month > DateTime.Now.Month)
            {
                edad -= 1;
            }

            return edad;
        }

        public string Mostrar()
        {
            return $"Nombre: {this.Nombre}\tFecha de nacimiento: {this.FechaDeNacimiento}\tEdad: {this.CalcularEdad()}\tDNI: {this.Dni}\n";
        }

        public string EsMayorDeEdad()
        {
            if(this.CalcularEdad() > 17)
            {
                return "Es mayor de edad";
            }
            return "Es menor";
        }
    }
}
