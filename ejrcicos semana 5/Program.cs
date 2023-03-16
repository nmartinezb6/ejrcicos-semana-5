
static double CalcularAreaDeCirculo()
{
    Console.Write("Por favor, introduce el radio del círculo: ");
    double radio = double.Parse(Console.ReadLine());
    double area = Math.PI * radio * radio;
    return area;
}
double area = CalcularAreaDeCirculo();
Console.WriteLine($"El área del círculo es {area}");


static double CalcularPerimetroDeRectangulo()
{
    Console.Write("Por favor, introduce el ancho del rectángulo: ");
    double ancho = double.Parse(Console.ReadLine());

    Console.Write("Por favor, introduce la altura del rectángulo: ");
    double altura = double.Parse(Console.ReadLine());

    double perimetro = 2 * (ancho + altura);
    return perimetro;
}

double perimetro = CalcularPerimetroDeRectangulo();
Console.WriteLine($"El perímetro del rectángulo es {perimetro}");



static string DeterminarParidadDesdeConsola()
{
    Console.Write("Por favor, introduce un número entero: ");
    string numeroString = Console.ReadLine();



    if (numero % 2 == 0)
    {
        return "par";
    }
    else
    {
        return "impar";
    }
}
string paridad = DeterminarParidadDesdeConsola();
Console.WriteLine($"El número introducido es {paridad}");




