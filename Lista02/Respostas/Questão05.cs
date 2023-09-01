using System;
class HelloWorld {
  static void Main() {
    int altura_porta, altura_tijolo, altura_janela, altura_parede, largura_porta, largura_tijolo, largura_janela, largura_parede;
    int area_tijolo, area_porta, area_janela, area_sala, area_parede, soma_portajanela, sala, total_tijolos;
    //tijolo
    Console.WriteLine("insira a altura do tijolo");
    altura_tijolo = int.Parse(Console.ReadLine());
   
    Console.WriteLine("insira a largura do tijolo");
    largura_tijolo = int.Parse(Console.ReadLine());
    
    //parede
    Console.WriteLine("insira a altura da parede");
    altura_parede = int.Parse(Console.ReadLine());
   
    Console.WriteLine("insira a largura da parede");
    largura_parede = int.Parse(Console.ReadLine());
    
    //janela
    Console.WriteLine("insira a altura da janela");
    altura_janela = int.Parse(Console.ReadLine());
    
    Console.WriteLine("insira a largura da janela");
    largura_janela = int.Parse(Console.ReadLine());
    
    //porta
    Console.WriteLine("insira a altura da porta");
    altura_porta = int.Parse(Console.ReadLine());
    
    Console.WriteLine("insira a largura da porta");
    largura_porta = int.Parse(Console.ReadLine());

    //areas
    area_tijolo = altura_tijolo * largura_tijolo;
    area_parede = altura_parede * largura_parede;
    area_porta = altura_porta * largura_porta;
    area_janela = altura_janela * largura_janela;
    
    //sala
    soma_portajanela = area_porta + area_janela;
    sala = (area_parede * 4) - soma_portajanela;
    total_tijolos = sala/area_tijolo;
    
    Console.WriteLine($"o total de tijolos é {total_tijolos}");

  }
}
