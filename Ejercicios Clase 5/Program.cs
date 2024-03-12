

using static System.Runtime.InteropServices.JavaScript.JSType;
int opcion;
do
{
    MostrarMenu();
    opcion = ObtenerOpcion();

    switch (opcion)
    {
        case 1:
            {
                CargaNumeros();
            }
            break;
        case 2:
            {
                AdivinarNumero();
            }
            break;
        case 3:
            {
                ContarPalabrasyVocales();
            }
            break;
        case 4:
            {
                PalabraPolíndromo();
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

static void MostrarMenu()
{
    Console.WriteLine("\n");
    Console.WriteLine("Seleccione la Opción que desea realizar");
    Console.WriteLine("\n");
    Console.WriteLine("----------- Menú -----------");
    Console.WriteLine("1. Cargar de Numeros");
    Console.WriteLine("2. Adivinar el Numero");
    Console.WriteLine("3. Contar Palabras y Numeros");
    Console.WriteLine("4. Identificador de palabras políndromos");
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




static void CargaNumeros()
{
    // Ejercicio 1#
    // Escribir un programa que solicite la carga de valores positivos,
    // hasta que el usuario ingrese un cero, luego muestre cual fue el 
    // numero mayor ingresado y el menor.

    int numero;
    int mayor = int.MinValue;
    int menor = int.MaxValue;

    do
    {
        Console.Write("Ingresa un número (ingresa 0 para salir): ");

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Por favor, ingresa un número positivo.");
            Console.Write("Ingresa un número (ingresa 0 para salir): ");
        }

        if (numero != 0)
        {

            mayor = Math.Max(mayor, numero);
            menor = Math.Min(menor, numero);
        }

    } while (numero != 0);

    if (mayor != int.MinValue && menor != int.MaxValue)
    {
        Console.WriteLine($"El número mayor ingresado fue: {mayor}");
        Console.WriteLine($"El número menor ingresado fue: {menor}");
    }
    else
    {
        Console.WriteLine("No se ingresaron números válidos.");
    }
}


static void AdivinarNumero()
{
    // Ejercicio 2#
    // Metodo para adivinar el numero que piensa una persona

    int respuesta, val1, val2;
    Console.WriteLine("Hola piense en un número entero positivo");
    Console.WriteLine("\n");
    Console.WriteLine("Al Numero Pensado multipliquelo por 2");
    Console.WriteLine("\n");
    Console.WriteLine("Al Numero Pensado despues de Multiplicar sumele 8");
    Console.WriteLine("\n");
    Console.WriteLine("Por ultimo al resultado multipliquelo por 5");
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese el Resultado final de las operaciones");
    val1 = Convert.ToInt32(Console.ReadLine());

    val2 = val1 / 10;
    respuesta = val2 - 4;
    Console.WriteLine("El Numero en el que penso es: " + respuesta);
}


static void ContarPalabrasyVocales()
{
    
    
        Console.Write("Ingresa una frase o una oración: ");
        string Palabra = Console.ReadLine();

        int cantidadPalabras = ContarPalabras(Palabra);

        Console.WriteLine($"La cantidad de palabras en la frase es: {cantidadPalabras}");

        static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return palabras.Length;
        }

        int cantidadVocales = ContarVocales(Palabra);

        Console.WriteLine($"La cantidad de vocales en la frase es: {cantidadVocales}");

        static int ContarVocales(string texto)
        {

            texto = texto.ToLower();

            int contadorVocales = 0;

            foreach (char caracter in texto)
            {
                if (EsVocal(caracter))
                {
                    contadorVocales++;
                }
            }

            return contadorVocales;
        }

        static bool EsVocal(char letra)
        {

            return "aeiou".Contains(letra);
        }
    
}

static void PalabraPolíndromo()
{
    Console.Write("Ingresa una palabra: ");
    string palabra = Console.ReadLine();

    if (EsPalindromo(palabra))
    {
        Console.WriteLine($"{palabra} es un palíndromo.");
    }
    else
    {
        Console.WriteLine($"{palabra} no es un palíndromo.");
    }


    static bool EsPalindromo(string palabra)
    {

        palabra = palabra.ToLower();

        int longitud = palabra.Length;

        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}