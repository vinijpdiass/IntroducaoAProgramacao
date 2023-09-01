using System;
class HelloWorld {
  static void coincide(int[] MAT045, int[] MAT037, int quantidadeMAT045, int quantidadeMAT037){
    int iguais = 0;
    for(int i = 0; i <= quantidadeMAT045; i++){
        for (int j = 0; j <= quantidadeMAT037; j++){
            if(MAT045[i] == MAT037[j]){
                iguais++;
            }
        }
    }
    Console.WriteLine(iguais);
  }
  static void Main() {
    int i = 0, quantidadeMAT045 = 0, quantidadeMAT037 = 0, numero;
    int[] MAT045 = new int[1000];
    int[] MAT037 = new int[1000];
    Console.WriteLine("digite a matricula dos alunos do curso MAT045");
    for(i = 0; i <= 1000; i++){
        numero = int.Parse(Console.ReadLine());
        
        if(numero == 999){
            break;
        }
        MAT045[i] = numero;
        quantidadeMAT045 = i;
    }
    Console.WriteLine("digite a matricula dos alunos do curso MAT037.");
    
    for(i = 0; i <= 1000; i++){
        numero = int.Parse(Console.ReadLine());
        
        if(numero == 999){
            break;
        }
        MAT037[i] = numero;
        quantidadeMAT037 = i;
        
    }
    coincide(MAT045, MAT037, quantidadeMAT045, quantidadeMAT037);
 }
}  
