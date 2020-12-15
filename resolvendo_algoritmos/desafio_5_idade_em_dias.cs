using System;

class MinhaClasse {
  public static void Main (string[] args) {
    const int qtdDiasAno = 365; // Considerando quantidade de dias como definido no problema, sem anos bissextos 
    const int qtdDiasMes = 30; // Considerando quantidade de dias como definido no problema
    var idadeEmDias = int.Parse(Console.ReadLine());
    var anos = idadeEmDias / qtdDiasAno; // Implemente aqui o calculo dos anos
    var meses = (idadeEmDias % qtdDiasAno) / qtdDiasMes; // Implemente aqui o calculo dos meses 
    var dias = (idadeEmDias % qtdDiasAno) % qtdDiasMes; // Implemente aqui o calculo dos dias

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}
