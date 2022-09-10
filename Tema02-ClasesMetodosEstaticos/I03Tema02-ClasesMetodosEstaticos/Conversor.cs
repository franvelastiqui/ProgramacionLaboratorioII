using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I03Tema02_ClasesMetodosEstaticos
{
    class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string acumulador = "";

            while(numeroEntero>=1)
            {
                if (numeroEntero % 2 == 0)
                {
                    acumulador = "0" + acumulador;
                }
                else
                {
                    acumulador = "1" + acumulador;
                }

                numeroEntero /= 2;
            }

            return acumulador;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string binario;
            int potencia;
            int acumulador = 0;

            binario = numeroEntero.ToString();
            potencia = binario.Length - 1;

            foreach(char bit in binario)
            {
                if(bit == '1')
                {
                    acumulador += 1 * (int)Math.Pow(2, potencia);
                }
                else
                {
                    acumulador += 0 * (int)Math.Pow(2, potencia);
                }
                potencia -= 1;
            }

            return acumulador;
        }
    }
}
