using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Tabela de conversões :\n1 - Fahrenheit para Celsius\n2 - Fahrenheit para Kelvin\n3 - Celsius para Fahrenheit\n4 - Celsius para Kelvin\n5 - Kelvin para Fahrenheit\n6 - Kelvin para Celsius\n");
    
    Console.Write("Insira a temperatura que deseja converter : ");
    
    if(!int.TryParse(Console.ReadLine(), out int temp)){
      Console.WriteLine("Valor inválido.");
      return;
    }
    
    Console.Write("\nDigite a opção de conversão desejada: ");
    
    if(!char.TryParse(Console.ReadLine(), out char a)){
      Console.WriteLine("Opção inválida.");
      return;
    }
    
    switch(a){
      case '1':
      Console.WriteLine($"A temperatura em Celsius é : {(temp - 32) * 5 / 9}");
      break;

      case '2':
      Console.WriteLine($"A temperatura em Kelvin é : {(temp - 32) * 5 / 9}");
      break;

      case '3':
      Console.WriteLine($"A temperatura em Fahrenheit é : {(temp * 9 / 5) + 32}");
      break;

      case '4':
      Console.WriteLine($"A temperatura em Kelvin é : {temp + 273.15}");
      break;

      case '5':
      Console.WriteLine($"A temperatura em Fahrenheit é : {temp * 9 / 5 - 459}");
      break;

      case '6':
      Console.WriteLine($"A temperatura em Celsius é : {temp - 273.15}");
      break;
    }
  }
}