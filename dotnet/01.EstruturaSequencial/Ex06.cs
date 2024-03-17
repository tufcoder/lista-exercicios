namespace EstruturaSequencial;

static class Ex06
{
    /// <summary>
    /// Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
    /// </summary>
    public static void Run()
    {
        Console.Write("Digite o raio do círculo: ");
        float raio = float.Parse(Console.ReadLine()!.Replace(".", ","));
        double area = Math.Round(Math.PI, 2) * Math.Pow(raio, 2);
        Console.Write($"A área do círculo é {area:F2}cm2");
    }
}