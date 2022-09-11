using System;
using Entidades;

namespace I01Tema03_ProgramacionOrientada
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaJuan = new Cuenta("Juan", 125);

            Console.WriteLine(cuentaJuan.Mostrar());

            cuentaJuan.Ingresar(200);

            Console.WriteLine(cuentaJuan.Mostrar());

            cuentaJuan.Retirar(1000);

            Console.WriteLine(cuentaJuan.Mostrar());
        }
    }
}
