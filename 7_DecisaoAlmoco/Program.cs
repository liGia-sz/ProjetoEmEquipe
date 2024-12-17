bool escolherDeNovo = true;

void WriteTitle()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(@"   ___          _                   __      ___   __                  ");
    Console.WriteLine(@"  / _ \___ ____(_)__ ___  ____  ___/ /__   / _ | / /_ _  ___  _______ ");
    Console.WriteLine(@" / // / -_) __/ (_-</ _ \/ __/ / _  / -_) / __ |/ /  ' \/ _ \/ __/ _ \");
    Console.WriteLine(@"/____/\__/\__/_/___/\___/_/    \_,_/\__/ /_/ |_/_/_/_/_/\___/\__/\___/");
    Console.WriteLine("                                                              /_)      ");
    Console.ResetColor();
    Console.WriteLine();
}
void WriteSubtitle(string texto)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(texto);
    Console.ResetColor();
    Console.WriteLine();
}
void ColorLineRed(string texto)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(texto);
    Console.ResetColor();
}
int GetValidOption(int maxOption)
{
    int option;
    while (true)
    {
        Console.Write("Digite sua opção: ");
        if (int.TryParse(Console.ReadLine(), out option) && option > 0 && option <= maxOption)
            return option - 1;

        else
            ColorLineRed("Opção inválida. Tente novamente.");
    }
}
void ChooseAgain()
{
    while (true)
    {
        Console.Write("Deseja fazer outra escolha? (S/N): ");
        string escolhaDeNovo = Console.ReadLine().ToUpper();
        if (escolhaDeNovo == "S")
        {
            escolherDeNovo = true;
            break;
        }
        else if (escolhaDeNovo == "N")
        {
            escolherDeNovo = false;
            return;
        }
        else
            ColorLineRed("Opção inválida. Tente novamente.");
    }
}

List<string> restaurantes = new List<string> { "Restaurante Italiano", "Churrascaria", "Restaurante Japonês", "Fast-Food", "Restaurante Vegetariano" };
List<List<string>> pratosPorRestaurante = new List<List<string>>
{
    new List<string> { "Lasanha de Berinjela", "Pizza Margherita", "Torta de Ricota" },       // Italiano
    new List<string> { "Batata Frita", "Picanha na Brasa", "Pizza Margherita" },              // Churrascaria
    new List<string> { "Hot Roll", "Ramen Tonkotsu", "Tempura de Legumes" },                  // Japonês
    new List<string> { "Batata Frita", "Cheeseburger", "Hot Roll" },                          // Fast-Food
    new List<string> { "Lasanha de Berinjela", "Salada Caesar Vegana", "Tempura de Legumes" } // Vegetariano
};
Random aleatorio = new Random();
int escolhaMenu = 0, escolhaRestaurante = 0, escolhaPrato = 0;

while (escolherDeNovo)
{
    WriteTitle();
    WriteSubtitle("— Menu —");
    Console.WriteLine("1- Escolher restaurante");
    Console.WriteLine("2- Escolher prato");
    Console.WriteLine("3- Estou indeciso(a), escolha por mim");
    escolhaMenu = GetValidOption(3) + 1;

    switch (escolhaMenu)
    {
        case 1:
            WriteTitle();
            WriteSubtitle("— Opções de Restaurantes —");
            for (int i = 0; i < restaurantes.Count; i++)
                Console.WriteLine($"{i + 1}- {restaurantes[i]}");
            escolhaRestaurante = GetValidOption(restaurantes.Count);

            WriteTitle();
            WriteSubtitle($"— Opções de Pratos em {restaurantes[escolhaRestaurante]} —");
            for (int i = 0; i < pratosPorRestaurante[escolhaRestaurante].Count; i++)
                Console.WriteLine($"{i + 1}- {pratosPorRestaurante[escolhaRestaurante][i]}");
            escolhaPrato = GetValidOption(pratosPorRestaurante[escolhaRestaurante].Count);

            WriteTitle();
            Console.WriteLine($"Você escolheu almoçar {pratosPorRestaurante[escolhaRestaurante][escolhaPrato]} em {restaurantes[escolhaRestaurante]}. Uma ótima pedida!");
            ChooseAgain();
            break;

        case 2:
            WriteTitle();
            HashSet<string> pratosUnicos = new HashSet<string>();
            foreach (var prato in pratosPorRestaurante)
                pratosUnicos.UnionWith(prato);
            List<string> pratos = pratosUnicos.ToList();

            WriteTitle();
            WriteSubtitle("— Opções de Pratos —");
            for (int i = 0; i < pratos.Count; i++)
                Console.WriteLine($"{i + 1}- {pratos[i]}");
            escolhaPrato = GetValidOption(pratos.Count);
            List<string> restaurantesComPrato = new List<string>();
            for (int i = 0; i < restaurantes.Count; i++)
            {
                if (pratosPorRestaurante[i].Contains(pratos[escolhaPrato]))
                    restaurantesComPrato.Add(restaurantes[i]);
            }
            if (restaurantesComPrato.Count > 0)
            {
                WriteTitle();
                WriteSubtitle($"— Opções de Restaurantes com {pratos[escolhaPrato]} —");
                for (int i = 0; i < restaurantesComPrato.Count; i++)
                    Console.WriteLine($"{i + 1}- {restaurantesComPrato[i]}");
                escolhaRestaurante = GetValidOption(restaurantesComPrato.Count);

                WriteTitle();
                Console.WriteLine($"Você escolheu almoçar {pratos[escolhaPrato]} em {restaurantesComPrato[escolhaRestaurante]}. Uma ótima pedida!");
                ChooseAgain();
            }
            break;

        case 3:
            WriteTitle();
            WriteSubtitle("— Escolha da Máquina —");
            int restauranteAleatorio = aleatorio.Next(restaurantes.Count);
            int pratoAleatorio = aleatorio.Next(pratosPorRestaurante[restauranteAleatorio].Count);
            Console.WriteLine($"Sugiro que almoce {pratosPorRestaurante[restauranteAleatorio][pratoAleatorio]} em {restaurantes[restauranteAleatorio]}. Que tal?!");
            ChooseAgain();
            break;
    }
}
WriteTitle();
Console.WriteLine("Saindo...");
Console.WriteLine("Tenha uma boa refeição!");