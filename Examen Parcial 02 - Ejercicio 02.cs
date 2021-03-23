using System;
using System.Linq;

namespace Examen_Parcial_02___Ejercicio_02
{
    class Program
    {
        static string CargarNombre()
        {
            Console.WriteLine("Introduzca un nombre:");
            string Nombre = Console.ReadLine();
            Console.Clear();
            return Nombre;
        }
        static int CargarSalario()
        {
            Console.WriteLine("Introduzca el salario:");
            int Salario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return Salario;
        }
        static void SalarioMayor()
        {
            string[] Nombres = new string[5];
            int[] Sueldos = new int[5];
            int C;
            for (C = 0; C <= 4; C++)
            {
                Nombres[C] = CargarNombre();
                Sueldos[C] = CargarSalario();
            }
            int Mayor = Sueldos.Max();
            int i;
            int N = 0;
            for (i = 0; i <= 4; i++)
            {
                if (Sueldos[i] == Mayor)
                {
                    N = i;
                }
            }
            Console.WriteLine("El empleado con el mayor salario es {0}", Nombres[N]);
            Console.WriteLine("Tiene un salario de: {0}", Mayor);
        }
        static void Main(string[] args)
        {
            SalarioMayor();
        }
    }
}
