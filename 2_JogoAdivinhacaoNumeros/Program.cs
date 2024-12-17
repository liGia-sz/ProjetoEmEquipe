using System;

public class Program
{
    public static void Main()
    {
        // Variáveis que definem o intervalo de números:
        int min = 0;
        int max = 100;

        //Gera número aleatório entre min e max:
        Random random = new Random();
        int Secretnum = random.Next(min, max + 1);
        int chute = 0;
        int tentativas = 0;

        Console.WriteLine("•┈••✦ ADIVINHE O NÚMERO ✦••┈• -");
        Console.WriteLine($"✧*̥˚ Adivinhe o número que estou pensando entre {min} e {max}*✧*̥˚");
        Console.WriteLine("Digite seu chute: ");
        // Converte a entrada do usuário em um número inteiro
        do
        {
            if (int.TryParse(Console.ReadLine(), out chute))
            {
                tentativas++;
                //Loop Do While

                if (chute < Secretnum)
                {
                    Console.Write("↓ MUITO BAIXO ↓ Tente novamente: ");
                }

                if (chute > Secretnum)
                {
                    Console.Write("↑ MUITO ALTO ↑. Tente novamente: ");
                }
            }
            else
            {
                Console.WriteLine($"˗ˏˋDigite um número entre 0 e 100´ˎ˗");
            }


            if (chute == Secretnum)
            {
                Console.WriteLine($"* ✩‧₊˚PARABÉNS! Você adivinhou em {tentativas} tentativas!* ✩‧₊˚");
            }

        }
        while (chute != Secretnum);
    }
}