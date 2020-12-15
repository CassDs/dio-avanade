using System;

class MinhaClasse {
  public static void Main (string[] args) {
    int tempoTotalEmSegundos = int.Parse(Console.ReadLine());
    
    int quantidadeDeHoras = tempoTotalEmSegundos / 3600;
    int quantidadeDeMinutos = (tempoTotalEmSegundos % 3600) / 60;
    int quantidadeDeSegundos = (tempoTotalEmSegundos % 3600) % 60;
    
    Console.Write($"{quantidadeDeHoras}:{quantidadeDeMinutos}:{quantidadeDeSegundos}");
      
  }
}
