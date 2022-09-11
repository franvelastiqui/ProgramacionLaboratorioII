using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get { return this.titular; }
        }

        public double Cantidad
        {
            get { return this.cantidad; }
        }

        public string Mostrar()
        {
            return $"Razón social: {this.Titular}\nMonto actual = {this.cantidad}";
        }
        
        public void Ingresar(double acreditado)
        {
            if(acreditado>0)
            {
                this.cantidad += acreditado;
            }
        }

        public void Retirar(double debitado)
        {
            this.cantidad -= debitado;
        }
    }
}
