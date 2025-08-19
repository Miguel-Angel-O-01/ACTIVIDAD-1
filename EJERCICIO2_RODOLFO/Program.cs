using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2_RODOLFO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            // Comparar cuál es mayor
            if (numero1 > numero2)
            {
                Console.WriteLine("El número mayor es: " + numero1);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("El número mayor es: " + numero2);
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }

            // Evita que se cierre inmediatamente la consola
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}