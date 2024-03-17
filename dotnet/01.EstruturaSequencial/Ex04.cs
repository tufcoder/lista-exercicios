namespace EstruturaSequencial;

static class Ex04
{
    /// <summary>
    /// Faça um Programa que peça as 4 notas bimestrais e mostre a média.
    /// </summary>
    public static void Run()
    {
        // decimal[] notas = new decimal[4];
        // List<decimal> notas = new List<decimal>([0, 0, 0, 0]);
        // List<decimal> notas = new([0, 0, 0, 0]);
        List<decimal> notas = [0, 0, 0, 0];
        // for (var i = 0; i < notas.Length; i++)
        for (var i = 0; i < notas.Count; i++)
        {
            Console.Write($"Digite uma nota: ");
            notas[i] = decimal.Parse(Console.ReadLine()!);
        }
        // var media = notas.Sum() / notas.Length;
        var media = notas.Sum() / notas.Count;
        Console.WriteLine($"A média das notas é: {media}");
    }
}