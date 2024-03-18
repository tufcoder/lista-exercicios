while (true)
{
    try
    {
        Console.Clear();
        Console.Write("Qual Ex: ");
        var exercicio = int.Parse(Console.ReadLine()!);
        switch (exercicio)
        {
            case 1:
                EstruturaSequencial.Ex01.Run(); Console.ReadLine(); break;
            case 2:
                EstruturaSequencial.Ex02.Run(); Console.ReadLine(); break;
            case 3:
                EstruturaSequencial.Ex03.Run(); Console.ReadLine(); break;
            case 4:
                EstruturaSequencial.Ex04.Run(); Console.ReadLine(); break;
            case 5:
                EstruturaSequencial.Ex05.Run(); Console.ReadLine(); break;
            case 6:
                EstruturaSequencial.Ex06.Run(); Console.ReadLine(); break;
            case 7:
                EstruturaSequencial.Ex07.Run(); Console.ReadLine(); break;
            case 8:
                EstruturaSequencial.Ex08.Run(); Console.ReadLine(); break;
            case 9:
                EstruturaSequencial.Ex09.Run(); Console.ReadLine(); break;
            case 10:
                EstruturaSequencial.Ex10.Run(); Console.ReadLine(); break;
            case 11:
                EstruturaSequencial.Ex11.Run(); Console.ReadLine(); break;
            case 12:
                EstruturaSequencial.Ex12.Run(); Console.ReadLine(); break;
            case 13:
                EstruturaSequencial.Ex13.Run(); Console.ReadLine(); break;
            case 14:
                EstruturaSequencial.Ex14.Run(); Console.ReadLine(); break;
            case 15:
                EstruturaSequencial.Ex15.Run(); Console.ReadLine(); break;
            case 16:
                EstruturaSequencial.Ex16.Run(); Console.ReadLine(); break;
            case 17:
                EstruturaSequencial.Ex17.Run(); Console.ReadLine(); break;
            default:
                EstruturaSequencial.Ex01.Run(); Console.ReadLine(); break;
        }
    }
    catch
    {
        Console.WriteLine("Erro no input");
        Console.Write("Pressione ENTER para continuar");
        Console.ReadLine();
    }
}