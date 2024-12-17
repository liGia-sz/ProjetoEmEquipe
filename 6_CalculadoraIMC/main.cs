using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Insira a sua altura : ");
    if(!float.TryParse(Console.ReadLine(), out float alt)){
      Console.WriteLine("Valor inserido inválido");
      return;
    }
    Console.Write("\nInsira o seu peso : ");
    if(!float.TryParse(Console.ReadLine(), out float peso)){
      Console.WriteLine("Valor inserido inválido");
      return;
    }

    Console.WriteLine($"\nSeu IMC é : {peso/(alt*alt):F2}" );
    if(peso/(alt*alt) < 18.5){
      Console.WriteLine("Você está abaixo do peso!");
    }
    else if(peso/(alt*alt) < 25){
      Console.WriteLine("Você está com o peso ideal!");
    }
    else if(peso/(alt*alt) < 30){
      Console.WriteLine("Você está com sobrepeso!");
    }
    else{
      Console.WriteLine("Você está obeso!");
    }
  }
}