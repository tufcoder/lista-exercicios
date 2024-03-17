namespace EstruturaSequencial;

static class Ex03
{
    /// <summary>
    /// Faça um Programa que peça dois números e imprima a soma.
    /// </summary>
    public static void Run()
    {
        int[] numeros = new int[2];
        for (var i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"A soma dos números é: {numeros.Sum()}");
    }
}