void WriteTitle()
{
	Console.Clear();
	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.WriteLine(new string('=', 32));
	Console.WriteLine("Simulador de Lançamento de Dados");
	Console.WriteLine(new string('=', 32));
	Console.ResetColor();
}

Random aleatorio = new Random();

WriteTitle();
Console.WriteLine("Pressione qualquer tecla para jogar o dado...");
Console.ReadKey();

while (true)
{
    WriteTitle();
    int numeroAleatorio = aleatorio.Next(1, 7);
    Console.WriteLine($"O dado caiu em: {numeroAleatorio}");

    while (true)
    {
        Console.Write("Quer jogar o dado novamente? (S/N): ");
        string jogarDeNovo = Console.ReadLine().ToUpper();

        if (jogarDeNovo == "S")
            break;
        else if (jogarDeNovo == "N")
        {
            WriteTitle();
            Console.WriteLine("Ok, saindo... Até a próxima!");
            return;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ResetColor();
        }
    }
}