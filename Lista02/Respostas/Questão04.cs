using System;
class Horas_minutos_segundos {
  static void Main() {
    int h, m, s, ch, cm, t;
    
    Console.WriteLine("insira as horas ");
    h = int.Parse(Console.ReadLine());
    Console.WriteLine("insira os minutos");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("insira os segundos");
    s = int.Parse(Console.ReadLine());

    ch = h * 3600;
    cm = m * 60;
    t = ch + cm + s;
    
    Console.WriteLine($"o total de segundos é {t}");

  }
}
