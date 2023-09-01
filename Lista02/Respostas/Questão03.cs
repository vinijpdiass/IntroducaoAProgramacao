using System;
class Lata_de_tinta {
  static void Main() {
    double alt, comp, area, resp;
    
    Console.WriteLine("insira a altura da parede");
    alt = double.Parse(Console.ReadLine());
    Console.WriteLine("insira o comprimento da parede");
    comp = double.Parse(Console.ReadLine());

    area = alt * comp;
    resp = (area * 0.3)/2;
    
    Console.WriteLine($"voce vai precisar de {resp} latas de tinta");

  }
}
