namespace EstruturaSequencial;

static class Ex18
{
    /// <summary>
    /// Faça um Programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um link
    /// de internet (em Mbps), calcule e informe o tempo aproximado de download do arquivo usando este
    /// link (em minutos).
    /// </summary>
    public static void Run()
    {
        Console.Write("Digite o tamanho do arquivo em MB: ");
        double tamanho = double.Parse(Console.ReadLine()!);
        Console.Write("Velocidade da internet em Mbps: ");
        double velocidade = double.Parse(Console.ReadLine()!);

        double minutos = (tamanho * 8 / velocidade) / 60;
        double segundos = (minutos - Math.Floor(minutos)) * 60;

        if (segundos > 0)
            Console.WriteLine($"O download irá demorar {Math.Floor(minutos)} minuto(s) e {Math.Round(segundos)} segundo(s)");
        else
            Console.WriteLine($"O download irá demorar {Math.Round(minutos)} minuto(s)");
    }
}