namespace EstruturaSequencial;

static class Ex05
{
    /// <summary>
    /// Faça um Programa que converta metros para centímetros.
    /// </summary>
    public static void Run()
    {
        Console.Write("Metros: ");
        float metros = float.Parse(Console.ReadLine()!.Replace(".", ","));
        float centimetros = metros * 100;
        Console.Write($"{metros:F2}m convertido em centímetros fica {centimetros:F2}cm");
    }
}