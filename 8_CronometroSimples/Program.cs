using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        Console.WriteLine("=".PadLeft(25, '='));
        Console.WriteLine("|\tCronômetro\t|");
        Console.WriteLine("=".PadLeft(25, '='));

        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("Pressione ENTER para iiniciar o cronõmetro...\n");
        Console.ReadLine();

        stopwatch.Start();
      
        Console.WriteLine("Cronômetro iniciado. Pressione ENTER para parar...\n");
        Console.ReadLine();

        stopwatch.Stop();

        TimeSpan tempoDecorrido = stopwatch.Elapsed;
        Console.WriteLine("Tempo decorrido: {0:hh\\:mm\\:ss\\.fff}", tempoDecorrido);
    }
}