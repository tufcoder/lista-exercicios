namespace EstruturaSequencial;

static class Ex08
{
    /// <summary>
    /// Faça um Programa que pergunte quanto você ganha por hora e o número
    /// de horas trabalhadas no mês. Calcule e mostre o total do seu salário
    /// no referido mês.
    /// </summary>
    public static void Run()
    {
        Console.Write("Salário hora R$ ");
        double salarioHora = double.Parse(Console.ReadLine()!);
        Console.Write("Horas trabalhadas: ");
        float horasTrabalhadas = float.Parse(Console.ReadLine()!);
        double salario = salarioHora * horasTrabalhadas;
        Console.Write($"Salário mensal R$ {salario:F2}");
    }
}