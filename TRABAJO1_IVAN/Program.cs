using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO1_IVAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el nombre del estudiante
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreEstudiante = Console.ReadLine();

            // Solicitar las notas
            Console.Write("Ingrese la nota de la guía (40%): ");
            float notaGuia = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del parcial (60%): ");
            float notaParcial = float.Parse(Console.ReadLine());

            // Calcular el promedio
            float promedio = (notaGuia * 0.4f) + (notaParcial * 0.6f);

            // Mostrar el resultado
            Console.WriteLine($"El promedio de {nombreEstudiante} es: {promedio}");

        }
    }
}
