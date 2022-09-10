using System;

namespace I07Tema01_Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorHora;
            string nombre;
            int antiguedad;
            bool flag;
            int horasTrabajadas;
            int cantidadEmpleados;
            double sueldoNeto;
            double sueldoBruto;

            Console.WriteLine("Ingrese la cantidad de empleados");
            _ = int.TryParse(Console.ReadLine(), out cantidadEmpleados);

            while(cantidadEmpleados<=0)
            {
                Console.WriteLine("Error. Reingrese la cantidad de empleados");
                _ = int.TryParse(Console.ReadLine(), out cantidadEmpleados);
            }

            for(int i = 0; i<cantidadEmpleados; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad: ");
                flag = int.TryParse(Console.ReadLine(), out antiguedad);

                while (flag == false || antiguedad<0)
                {
                    Console.WriteLine("Error. Reingrese la antiguedad");
                    flag = int.TryParse(Console.ReadLine(), out antiguedad);
                }

                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                _ = int.TryParse(Console.ReadLine(), out horasTrabajadas);

                while (horasTrabajadas <= 0)
                {
                    Console.WriteLine("Error. Reingrese la cantidad de horas trabajadas: ");
                    _ = int.TryParse(Console.ReadLine(), out horasTrabajadas);
                }

                Console.WriteLine("Ingrese el valor hora: ");
                _ = double.TryParse(Console.ReadLine(), out valorHora);

                while (valorHora <= 0)
                {
                    Console.WriteLine("Error. Reingrese el valor hora: ");
                    _ = double.TryParse(Console.ReadLine(), out valorHora);
                }

                sueldoNeto = valorHora * horasTrabajadas + antiguedad * 150;
                sueldoBruto = sueldoNeto - sueldoNeto * 0.13;

                Console.WriteLine($"{nombre}\t{antiguedad} años\t{valorHora} p/hora\t{sueldoNeto} neto\t{sueldoBruto} bruto");
            }

        }
    }
}
