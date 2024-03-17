namespace EstruturaSequencial;

static class Ex11
{
    /// <summary>
    /// Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
    ///     a. o produto do dobro do primeiro com metade do segundo.
    ///     b. a soma do triplo do primeiro com o terceiro.
    ///     c. o terceiro elevado ao cubo.
    /// </summary>
    public static void Run()
    {
        int[] inteiros = new int[2];
        for (var i = 0; i < inteiros.Length; i++)
        {
            Console.Write("Digite um número inteiro: ");
            inteiros[i] = int.Parse(Console.ReadLine()!);
        }
        Console.Write("Digite um número real: ");
        double real = double.Parse(Console.ReadLine()!);
        double a = inteiros[0] * 2 + (inteiros[1] / 2);
        double b = inteiros[0] * 3 + real;
        double c = Math.Pow(real, 3);
        Console.WriteLine($"O produto do dobro do primeiro com metade do segundo: {a}");
        Console.WriteLine($"A soma do triplo do primeiro com o terceiro: {b}");
        Console.WriteLine($"O terceiro elevado ao cubo: {c}");
    }
}