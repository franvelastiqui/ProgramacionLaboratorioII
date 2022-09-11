using System;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota[] mascotas;

        public Cliente(string nombre, string apellido, string domicilio, string telefono, int numeroMascotas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascotas = new Mascota[numeroMascotas];
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Domicilio { get => domicilio; }
        public string Telefono { get => telefono; }
        internal Mascota[] Mascotas { get => mascotas; }

        public bool AgregarMascota(Mascota m)
        {
            for (int i = 0; i < this.mascotas.Length; i++)
            {
                if (this.mascotas[i] == null)
                {
                    mascotas[i] = m;
                    return true;
                }
            }

            return false;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cliente: {apellido}, {nombre}\t{domicilio}\t{telefono}");
            for(int i = 0; i < this.mascotas.Length; i++)
            {
                if(mascotas[i] != null)
                {
                    sb.Append(Mascota.MostrarMascota(mascotas[i]));
                }
            }

            return sb.ToString();
        }
    }
}
