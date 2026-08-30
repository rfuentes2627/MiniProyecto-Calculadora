Console.WriteLine("=== MINI CALCULADORA ===");

Console.Write("Ingrese el primer número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nSeleccione una operación:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

Console.Write("Opción: ");
string? opcion = Console.ReadLine();

double resultado;

switch (opcion)
{
    case "1":
        resultado = numero1 + numero2;
        Console.WriteLine($"Resultado: {resultado}");
        break;

    case "2":
        resultado = numero1 - numero2;
        Console.WriteLine($"Resultado: {resultado}");
        break;

    case "3":
        resultado = numero1 * numero2;
        Console.WriteLine($"Resultado: {resultado}");
        break;

    case "4":
        if (numero2 != 0)
        {
            resultado = numero1 / numero2;
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: no se puede dividir entre cero.");
        }
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}

Console.WriteLine("\nPresione una tecla para finalizar...");
Console.ReadKey();
