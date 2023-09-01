using System;
class relogio {
  static void Main() {
    int horas = 0, minutos = 0, segundos = 0, i = 0;  
    
    do {
        segundos++;
        if (segundos == 60){
            minutos++;
            segundos = 0;
        }
        if (minutos == 60){
            horas++;
            minutos = 0;
            segundos = 0;
        }
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }while(horas != 24);
    }
}
