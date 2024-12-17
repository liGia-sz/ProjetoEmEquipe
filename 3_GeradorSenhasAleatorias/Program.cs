using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("GERADOR DE SENHAS");
        // Solicita ao usuário o comprimento da senha
        Console.Write("Digite o número de caracteres da sua nova senha: ");
        
        // Verifica se a entrada é um número válido é maior que 0
        if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
        {
            // Gera a senha usando o comprimento especificado
            string senha = GerarSenha(length);
            // Exibe a senha gerada
            Console.WriteLine($"Senha gerada: {senha}");
        }
        else
        {
            // Mensagem de erro para entrada inválida
            Console.WriteLine("Comprimento inválido. Por favor, insira um número positivo.");
        }
    }

    static string GerarSenha(int comprimento)
    {
        // Conjunto de caracteres que podem ser usados na senha (letras e números)
        const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        
        // StringBuilder para construir a senha de forma eficiente
        StringBuilder senhaBuilder = new StringBuilder();
        Random random = new Random(); // Inicializa um gerador de números aleatórios

        // Loop para gerar cada caractere da senha
        for (int i = 0; i < comprimento; i++)
        {
            // Seleciona um índice aleatório do conjunto de caracteres
            int indice = random.Next(caracteres.Length);
            // Adiciona o caractere correspondente ao StringBuilder
            senhaBuilder.Append(caracteres[indice]);
        }

        // Retorna a senha gerada como uma string
        return senhaBuilder.ToString();
    }
}