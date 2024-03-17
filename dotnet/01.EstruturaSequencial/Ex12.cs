namespace EstruturaSequencial;

static class Ex12
{
    /// <summary>
    /// Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo
    /// que calcule seu peso ideal, usando a seguinte fórmula: (72.7 * altura) - 58
    /// </summary>
    public static void Run()
    {
        Console.Write("Digite a altura em metros: ");
        float altura = float.Parse(Console.ReadLine()!);
        double peso = Math.Round((72.7 * altura) - 58, 2);
        Console.WriteLine($"O peso ideal para a altura {altura}m é {peso}kg");
    }
}