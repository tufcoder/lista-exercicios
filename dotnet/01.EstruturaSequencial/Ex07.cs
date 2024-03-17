namespace EstruturaSequencial;

static class Ex07
{
    /// <summary>
    /// Faça um Programa que calcule a área de um quadrado, em seguida mostre
    /// o dobro desta área para o usuário.
    /// </summary>
    public static void Run()
    {
        Console.Write("Digite o lado do quadrado: ");
        float lado = float.Parse(Console.ReadLine()!.Replace(".", ","));
        double area = Math.Pow(lado, 2) * 2;
        Console.Write($"A área do quadrado é {area:F2}");
    }
}