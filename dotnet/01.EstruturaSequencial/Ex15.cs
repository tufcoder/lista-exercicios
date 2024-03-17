namespace EstruturaSequencial;

static class Ex15
{
    /// <summary>
    /// Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês.
    /// Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para
    /// o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
    ///     a. salário bruto.
    ///     b. quanto pagou ao INSS.
    ///     c. quanto pagou ao sindicato.
    ///     d. o salário líquido.
    ///     e. calcule os descontos e o salário líquido, conforme a tabela abaixo:
    ///         + Salário Bruto : R$
    ///         - IR (11%) : R$
    ///         - INSS (8%) : R$
    ///         - Sindicato ( 5%) : R$
    ///         = Salário Liquido : R$
    ///         Obs.: Salário Bruto - Descontos = Salário Líquido. 
    /// </summary>
    public static void Run()
    {
        const double IR = 0.11d;
        const double INSS = 0.08d;
        const double SINDICATO = 0.05d;

        Console.Write("Digite o seu valor hora R$ ");
        double valorHora = double.Parse(Console.ReadLine()!);
        Console.Write("Digite o total de horas trabalhadas: ");
        double horasTrabalhadas = double.Parse(Console.ReadLine()!);

        double salarioBruto = valorHora * horasTrabalhadas;
        double valorIR = salarioBruto * IR;
        double valorINSS = salarioBruto * INSS;
        double valorSindicato = salarioBruto * SINDICATO;
        double descontos = valorIR + valorINSS + valorSindicato;
        double salarioLiquido = salarioBruto - descontos;

        Console.WriteLine($"\t+ Salário Bruto: R$ {salarioBruto:F2}");
        Console.WriteLine($"\t- IR(11%): R$ {valorIR:F2}");
        Console.WriteLine($"\t- INSS(8%): R$ {valorINSS:F2}");
        Console.WriteLine($"\t- Sindicato(5%): R$ {valorSindicato:F2}");
        Console.WriteLine($"\t= Salário Líquido: R$ {salarioLiquido:F2}");
        Console.WriteLine($"O total de descontos é de R$ {descontos:F2}");
    }
}