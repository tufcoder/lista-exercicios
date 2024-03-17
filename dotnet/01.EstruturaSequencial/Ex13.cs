namespace EstruturaSequencial;

static class Ex13
{
    /// <summary>
    /// Tendo como dados de entrada a altura (h) de uma pessoa, construa um 
    /// algoritmo que calcule seu peso ideal, usando as seguintes fórmulas:
    ///     a. Para homens: (72.7 * h) - 58
    ///     b. Para mulheres: (62.1 * h) - 44.7
    /// </summary>
    public static void Run()
    {
        double altura, pesoHomem, pesoMulher;
        Console.Write("Digite a altura em metros: ");
        altura = float.Parse(Console.ReadLine()!);
        pesoHomem = Math.Round((72.7 * altura) - 58, 2);
        pesoMulher = Math.Round((62.1 * altura) - 44.7, 2);
        Console.WriteLine($"O peso ideal para a altura {altura}m é:");
        Console.WriteLine($"\ta. Para homens: {pesoHomem}kg");
        Console.WriteLine($"\tb. Para mulheres: {pesoMulher}kg");
    }
}