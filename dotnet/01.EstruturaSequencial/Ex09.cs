namespace EstruturaSequencial;

static class Ex09
{
    /// <summary>
    /// Faça um Programa que peça a temperatura em graus Fahrenheit, transforme
    /// e mostre a temperatura em graus Celsius.
    /// C = ((F-32)/9)
    /// </summary>
    public static void Run()
    {
        Console.Write("Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine()!);
        double celsius = Math.Round(5 * ((fahrenheit - 32) / 9), 2);
        Console.Write($"A temperatura convertida em Celsius é: {celsius} graus");
    }
}