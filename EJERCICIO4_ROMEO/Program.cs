using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4_ROMEO
{
    internal class Program
 
    {
            static void Main(string[] args)
            {
                // Agregar el número
                Console.Write("Ingrese un número entero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                // Uso del operador ternario
                string resultado = (numero > 0) ? "El número es positivo."
                                 : (numero < 0) ? "El número es negativo."
                                 : "El número es cero.";

                // Mostrar resultado
                Console.WriteLine(resultado);

                Console.WriteLine("\nPresione una tecla para salir...");
                Console.ReadKey();
            }
        }
    }
 
        
        
    

