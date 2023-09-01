using System;
class HelloWorld {
   static void entrada(float[] nota){
        float somanota = 0, maior = 0, media = 0;
        int i = 0;
        for(i = 0; i<10; i++){
            somanota = somanota + nota[i];
        }
        media = somanota / 10;
        for(i = 0; i<10; i++){
            if(nota[i] > maior){
            maior = nota[i];
            }
        }
        Console.WriteLine($"A média das notas é :{media}\nA maior nota é:{maior}");
    

  }

  static void Main() {
    float[] nota  = new float[10];
    int i = 0;
    for(i = 0; i<10; i++){
        Console.WriteLine($"Escreva a nota do {i+1}° aluno");
        nota[i] = float.Parse(Console.ReadLine());
    }
    entrada(nota);
  } 
}
