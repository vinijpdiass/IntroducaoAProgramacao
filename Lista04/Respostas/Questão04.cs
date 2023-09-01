using System;
class lista {
  static void Main() {
    int numero, i;
      
    Console.WriteLine("diga um numero entre 0 e 100");
    numero = int.Parse(Console.ReadLine());

    for(i = 0; i <= 100; i++){
        Console.WriteLine(i);
        
        if(i == numero){
            break;
        }
    }   
      
  }
}
