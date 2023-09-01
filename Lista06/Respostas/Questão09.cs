using System;
class HelloWorld {
  static void Main() {
    int i = 0, j = 0, numero;
    int[] A = new int[10];
    int[] B = new int[10];
    int[] C = new int[10];
    int[] D = new int[20];
    Console.WriteLine("digite o primeiro vetor");
    for(i = 0; i < 10; i++){
        numero = int.Parse(Console.ReadLine());
        
        if(numero == 999){
            break;
        }
        A[i] = numero;
    }
    Console.WriteLine("digite o segundo vetor");
    
    for(i = 0; i < 10; i++){
        numero = int.Parse(Console.ReadLine());
        
        if(numero == 999){
            break;
        }
        B[i] = numero;
    }
   for(i = 0; i < 10; i++){
        for (j = 0; j < 10; j++){
            if(A[i] == B[j]){
                C[i] = A[i];
            }
        }
    }
    for(i = 0; i < 10; i++){
      D[i] = A[i];
      for(j = 0; j < 10; j++){
        if(B[i] == A[j]){
            B[i] = 0;
        }
      }
    }
    int v = i;
    for(i = 0; i < 10; i++){
        D[v] = B[i];
        v++;
    }
    
    Console.WriteLine("C: ");
    for(i = 0; i < 10; i++){
        if(C[i] == 0){
            continue;
        }else{
        Console.Write("{0}\t", C[i]);
        }
    }
    Console.WriteLine("\nD: ");
    for(i = 0; i < 20; i++){
       if(D[i] == 0){
            continue;
        }
        Console.Write("{0}\t", D[i]);
    }

  }
}
