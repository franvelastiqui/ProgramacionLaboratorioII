using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I05Tema02_ClasesMetodosEstaticos
{
    class Tabla
    {
        public static string DevolverTabla(int numero)
        {
            StringBuilder acumulador = new StringBuilder();

            for(int i = 1; i<10; i ++)
            {
                acumulador.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return acumulador.ToString();
        }
    }
}
