using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01Tema02_ClasesMetodosEstaticos
{
    class Validador
    {
       public static bool Validar(int valor, int min, int max)
        {
            if(valor<-100 || valor>100)
            {
                return false;
            }

            return true;
        }
    }
}
