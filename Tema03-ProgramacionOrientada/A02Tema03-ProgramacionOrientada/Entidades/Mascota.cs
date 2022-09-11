using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        private string nombre;
        private int fecha;
        private string especie;
        private string[] vacunas;

        public Mascota(string nombre, int fecha, string especie)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.especie = especie;
            this.vacunas = new string[3];
        }

        public bool AgregarVacuna(string vacuna)
        {
            for(int i = 0; i<3; i++)
            {
                if(this.vacunas[i] == null)
                {
                    vacunas[i] = vacuna;
                    return true;
                }
            }

            return false;
        }

        internal static string MostrarMascota(Mascota m)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{m.especie} {m.nombre}.");

            for(int i = 0; i<3; i++)
            {
                if(m.vacunas[i] != null)
                {
                    sb.Append($" {m.vacunas[i]}.");
                }
            }

            sb.AppendLine("\n");

            return sb.ToString();
        }
    }
}
