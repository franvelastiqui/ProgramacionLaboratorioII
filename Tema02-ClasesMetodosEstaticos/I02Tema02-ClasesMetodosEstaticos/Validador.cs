using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02Tema02_ClasesMetodosEstaticos
{
    class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if(respuesta == "s" || respuesta == "S")
            {
                return true;
            }
            return false;
        }
    }
}
