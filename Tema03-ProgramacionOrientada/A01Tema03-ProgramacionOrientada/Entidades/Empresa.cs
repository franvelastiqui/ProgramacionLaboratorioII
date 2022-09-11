using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        Conductor[] conductores;

        public Empresa(Conductor[] conductores)
        {
            this.conductores = conductores;
        }

       public string MostrarGanadorPorDia(string dia)
       {
            string ganador = "";
            double km  = -1;
            int diaIntegral;

            if (Enum.IsDefined(typeof(Dias), dia))
            {
                diaIntegral = (int)Enum.Parse(typeof(Dias), dia, true);

                foreach (Conductor c in conductores)
                {
                    if (km < c.KmRecorridos[diaIntegral])
                    {
                        km = c.KmRecorridos[diaIntegral];
                        ganador = c.Nombre;
                    }
                }
                return ganador;
            }

            return "Dia no valido";
       }

        public string MostrarGanadorDeSemana()
        {
            double km = 0;
            double mayor = 0;
            string ganador = "";

            foreach (Conductor c in conductores)
            {
                for(int i = 0; i<7; i++)
                {
                    km += c.KmRecorridos[i];
                }

                if(km>mayor)
                {
                    mayor = km;
                    ganador = c.Nombre;
                }

            }

            return ganador;

        }
           
    }
}
