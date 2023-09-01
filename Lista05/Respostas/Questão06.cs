using System;
class relogio {
  static int segundos(int segundos){
          segundos++;
          return segundos;
    }
  static int minutos(int minutos){
          minutos++;
          return minutos;
    }
  static int horas(int horas){
            horas++;
            return horas;
    }
  static void Main() {
    int hora = 0, minuto = 0, segundo = 0;  
    do{
        if(segundo < 60){
            segundo = segundos(segundo);
        }
        if(segundo == 60){
            segundo = 0;
            minuto = minutos(minuto);
        }
        if(minuto == 60){
            segundo = 0;
            minuto = 0;
            hora = horas(hora);
        }
        Console.WriteLine($"{hora}:{minuto}:{segundo}");
    }while(hora!=24);
    
}
}
