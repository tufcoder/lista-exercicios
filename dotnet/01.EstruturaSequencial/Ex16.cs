namespace EstruturaSequencial;

static class Ex16
{
    /// <summary>
    /// Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados
    /// da área a ser pintada. Considere que a a cobertura da tinta é de 1 litro para cada 3 metros
    /// quadrados e que a tinha é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao usuário
    /// a quantidade de latas de tinta a serem compradas e o preço total.
    /// </summary>
    public static void Run()
    {
        const double COBERTURA = 1 * 3;
        const int LITROS_LATA = 18;
        const double PRECO_LATA = 80d;

        Console.Write("Área a ser pintada em m2: ");
        double area = double.Parse(Console.ReadLine()!);
        double litros = area / COBERTURA;
        int latas = (int)Math.Round(litros / LITROS_LATA);
        double precoTotal = latas * PRECO_LATA;

        Console.WriteLine($"Você precisa comprar {latas} lata(s) de tinta");
        Console.WriteLine($"O preço total é de R$ {precoTotal:F2}");
    }
}