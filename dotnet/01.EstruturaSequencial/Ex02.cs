namespace EstruturaSequencial;

static class Ex02
{
    /// <summary>
    /// Faça um Programa que peça um número e então mostre a mensagem
    /// "O número informado foi [número]."
    /// </summary>
    public static void Run()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);
        Console.Write($"O número informado foi [{numero}]");
    }
}