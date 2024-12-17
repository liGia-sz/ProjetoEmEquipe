using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("=".PadLeft(81,'='));
        Console.WriteLine("|\tInforme 2 números para fazer uma operação matemática de sua escolha:\t|");        
        Console.WriteLine("=".PadLeft(81,'='));
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Escolha uma operação matemática apertando: A , S , M ou D \n");
        return1:
        ConsoleKeyInfo pressedKey = Console.ReadKey();
        Console.WriteLine($"\nVocê apertou a tecla: {pressedKey.KeyChar}\n");

        if (pressedKey.Key == ConsoleKey.A)
        {
            Console.WriteLine("Você escolheu ADIÇÃO.");
            int resultado = n1 + n2;
            Console.WriteLine($"\n{n1} + {n2} = {resultado}");
        }
        else if (pressedKey.Key == ConsoleKey.S)
        {
            Console.WriteLine("Você escolheu SUBTRAÇÃO.");
            int resultado = n1 - n2;
            Console.WriteLine($"\n{n1} - {n2} = {resultado}");
        }
        else if (pressedKey.Key == ConsoleKey.M)
        {
            Console.WriteLine("Você escolheu MULTIPLICAÇÃO.");
            int resultado = n1 * n2;
            Console.WriteLine($"\n{n1} * {n2} = {resultado}");
        }
        else if (pressedKey.Key == ConsoleKey.D)
        {
            Console.WriteLine("Você escolheu DIVISÃO.");
            int resultado = n1 / n2;
            Console.WriteLine($"\n{n1} / {n2} = {resultado}");
        }
        else
        {
            Console.WriteLine("\nAperte apenas A, S, M ou D!\n");
            goto return1;            
        }
    }
}