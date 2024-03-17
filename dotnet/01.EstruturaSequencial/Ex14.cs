namespace EstruturaSequencial;

static class Ex14
{
    /// <summary>
    /// João Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar
    /// o rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes
    /// maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
    /// (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. João precisa
    /// que você faça um programa que leia a variável *peso* (peso de peixes) e calcule
    /// o excesso. Gravar na variável *excesso* a quantidade de quilos além do limite e
    /// na variável *multa* o valor da multa que João deverá pagar. Imprima os dados do
    /// programa com as mensagens adequadas.
    /// </summary>
    public static void Run()
    {
        const double PESO_LIMITE = 50d;
        const double VALOR_MULTA = 4d;

        Console.Write("Peso de peixes em kg: ");
        double peso = Math.Round(double.Parse(Console.ReadLine()!), 2);
        double excesso = Math.Round(peso - PESO_LIMITE, 2);
        double multa = Math.Round(excesso * VALOR_MULTA, 2);

        Console.WriteLine($"Você informou que pescou {peso}kg de peixes");
        if (excesso > 0)
        {
            Console.WriteLine($"Peso excedido: {excesso}kg");
            Console.WriteLine($"Você passou do limite, deverá pagar uma multa de R$ {multa}");
        }
        else
            Console.WriteLine("O peso limite não foi excedido, você não tem multa para pagar :)");
    }
}