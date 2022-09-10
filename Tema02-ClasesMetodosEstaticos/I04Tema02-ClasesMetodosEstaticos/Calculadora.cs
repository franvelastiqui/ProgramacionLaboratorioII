using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I04Tema02_ClasesMetodosEstaticos
{
    class Calculadora
    {
        public static string Calcular(double primerOperando, double segundoOperando, char operador)
        {
            switch(operador)
            {
                case '+':
                    return (primerOperando + segundoOperando).ToString();
                case '-':
                    return (primerOperando - segundoOperando).ToString();
                case '*':
                    return (primerOperando * segundoOperando).ToString();
                case '/':
                    if(Validar(segundoOperando))
                    {
                        return (primerOperando / segundoOperando).ToString();
                    }
                    return "ERROR. No se puede dividir por cero";
                default:
                    return "Operador no válido";
            }
        }

        private static bool Validar(double segundoOperando)
        {
            if(segundoOperando == 0)
            {
                return false;
            }

            return true;
        }
    }
}
