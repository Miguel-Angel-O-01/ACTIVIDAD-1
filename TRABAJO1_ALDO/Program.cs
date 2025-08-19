using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO1_ALDO
{
  

namespace EJERCICIO5
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double num1, num2;
                string clave;

                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la clave (+, -, *, /): ");
                clave = Console.ReadLine();

                switch (clave)
                {
                    case "+":
                        Console.WriteLine("Resultado: " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine("Resultado: " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("Resultado: " + (num1 * num2));
                        break;
                    case "/":
                        if (num2 != 0)
                            Console.WriteLine("Resultado: " + (num1 / num2));
                        else
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        break;
                    default:
                        Console.WriteLine("Clave inválida.");
                        break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }
}
    
