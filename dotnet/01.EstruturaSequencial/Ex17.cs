namespace EstruturaSequencial;

static class Ex17
{
    /// <summary>
    /// Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados
    /// da área a ser pintada. Considere que a a cobertura da tinta é de 1 litro para cada 6 metros
    /// quadrados e que a tinha é vendida em latas de 18 litros, que custam R$ 80,00, ou galões de 
    /// 3,6 litros, que custam R$ 25,00.
    /// Informe ao usuário a quantidade de tinta a serem compradas e os respectivos preços em 3 situações:
    ///     * comprar apenas latas de 18 litros;
    ///     * comprar apenas galões de 3,6 litros;
    ///     * misturar latas e galões, de forma que o desperdício de tinta seja menor. Acrescente 10% de
    ///       folga e sempre arredonde os valores para cima, isto é, considere latas cheias.
    /// </summary>
    public static void Run()
    {
        const double COBERTURA = 1 * 6;
        const double LITROS_LATA = 18d;
        const double LITROS_GALAO = 3.6d;
        const double PRECO_LATA = 80.0d;
        const double PRECO_GALAO = 25.0d;
        const double FOLGA = 1.1d;

        Console.Write("Área a ser pintada em m2: ");
        double area = double.Parse(Console.ReadLine()!);

        double litros = area / COBERTURA;
        double latas = Math.Ceiling(litros / LITROS_LATA);
        double galoes = Math.Ceiling(litros / LITROS_GALAO);
        double precoLatas = latas * PRECO_LATA;
        double precoGaloes = galoes * PRECO_GALAO;

        double litrosFolga = litros * FOLGA;
        double latasFolga = Math.Floor(litrosFolga / LITROS_LATA);

        litrosFolga = litrosFolga - latasFolga * LITROS_LATA;

        double galoesFolga = Math.Ceiling(litrosFolga / LITROS_GALAO);
        double precoLatasFolga = latasFolga * PRECO_LATA;
        double precoGaloesFolga = galoesFolga * PRECO_GALAO;

        Console.WriteLine("Apenas latas de 18 litros:");
        Console.WriteLine($"\t{latas} lata(s) de tinta cutando R$ {precoLatas:F2}");
        Console.WriteLine("Apenas galões de 3,6 litros:");
        Console.WriteLine($"\t{galoes} lata(s) de tinta cutando R$ {precoGaloes:F2}");
        Console.WriteLine($"Misturar latas e galões. 10% de folga {litros * FOLGA:F2}l:");
        Console.WriteLine($"\tLatas: {latasFolga} lata(s) custando R$ {precoLatasFolga:F2}");
        Console.WriteLine($"\tGalões: {galoesFolga} gal(ão/ões) custando R$ {precoGaloesFolga:F2}");
        Console.WriteLine($"\tValor total: R$ {precoLatasFolga + precoGaloesFolga:F2}");
    }
}