namespace EstruturaSequencial;

static class Ex10
{
    /// <summary>
    /// Faça um Programa que peça a temperatura em graus Celsius, transforme
    /// e mostre em graus Fahrenheit.
    /// </summary>
    public static void Run()
    {
        Console.Write("Celsius: ");
        double celsius = double.Parse(Console.ReadLine()!);
        double fahrenheit = Math.Round(celsius * 9 / 5 + 32, 2);
        Console.Write($"A temperatura convertida em Fahrenheit é: {fahrenheit} graus");
    }
}