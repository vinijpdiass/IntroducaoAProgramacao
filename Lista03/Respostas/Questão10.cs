using System;
class HelloWorld {
  static void Main() {
    int pista, carro1, carro2, velocidade1, velocidade2;
    Console.WriteLine("Informe o tamanho da pista em metros");
    pista = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a quantidade de segundos que o\nprimeiro carro demorou para completar o percurso");
    carro1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a quantidade de segundos que o \nsegundo carro demorou para completar o percurso");
    carro2 = int.Parse(Console.ReadLine());
    
    velocidade1 = pista/carro1;
    velocidade2 = pista/carro2;
    
    if (velocidade1 > velocidade2){
        Console.WriteLine($"O primeiro carro é mais rápido, chegando a velocidade de {velocidade1}m/s");
    }else{
        Console.WriteLine($"O segundo carro é mais rápido, chegando a velocidade de {velocidade2}m/s");
    }
  }
}
