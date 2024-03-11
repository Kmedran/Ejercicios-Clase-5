using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicos_de_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarMenu();
                opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        {
                            suma();
                        }
                        break;
                    case 2:
                        {
                            datos();
                        }
                        break;
                    case 3:
                        {
                            CalculoEdad();
                        }
                        break;
                    case 0:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                        break;
                }

            } while (opcion != 0);

        }

        static void datos()
        {
            // Ejer 2
            Console.Write("Cual es tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Mucho gusto " + nombre);

        }

        static void CalculoEdad()
        {
            // Ejer 3
            Console.WriteLine("Ingrese su año de nacimiento");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            int edad = 2024 - yearBorn;
            Console.WriteLine("Su edad es=" + edad);

        }

        static void suma()
        {
            int respuesta, val1, val2 = 0;
            Console.WriteLine("Ingrese valor 1:");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese valor 2:");
            val2 = Convert.ToInt32(Console.ReadLine());
            respuesta = val1 + val2;
            Console.WriteLine("Suma =" + respuesta);
        }
        static void MostrarMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Seleccione la Opción que desea realizar");
            Console.WriteLine("\n");
            Console.WriteLine("----------- Menú -----------");
            Console.WriteLine("1. Sumas");
            Console.WriteLine("2. Datos");
            Console.WriteLine("3. Edad");
            Console.WriteLine("0. Salir");
            Console.WriteLine("-----------------------------");
        }

        static int ObtenerOpcion()
        {
            Console.Write("Elige una opción: ");
            int opción;
            while (!int.TryParse(Console.ReadLine(), out opción))
            {
                Console.WriteLine("Por favor, introduce un número válido.");
                Console.Write("Elige una opción: ");
            }
            return opción;
        }
    }
}