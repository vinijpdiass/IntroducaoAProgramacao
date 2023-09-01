using System;
class HelloWorld {
  
  static void Main() {
    int[] vetor = new int[10];
    int[] maior =new int[1];
    int[,] matrizresultado = new int[10,2];
    int i, j, v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0, v10 = 0;

    for(i = 0; i < 10; i++){
    Console.WriteLine($"digite o {i + 1}° voto");
    vetor[i] = int.Parse(Console.ReadLine());
    }

    for(i = 0; i < 10; i++){
        if(vetor[i] == 1){
            v1++;
            matrizresultado[0,1] = v1;
        }else if(vetor[i] == 2){
            v2++;
            matrizresultado[1,1] = v2;
        }else if(vetor[i] == 3){
            v3++;
            matrizresultado[2,1] = v3;
        }else if(vetor[i] == 4){
            v4++;
            matrizresultado[3,1] = v4;
        }else if(vetor[i] == 5){
            v5++;
            matrizresultado[4,1] = v5;
        }else if(vetor[i] == 6){
            v6++;
            matrizresultado[5,1] = v6;
        }else if(vetor[i] == 7){
            v7++;
            matrizresultado[6,1] = v7;
        }else if(vetor[i] == 8){
            v8++;
            matrizresultado[7,1] = v8;
        }else if(vetor[i] == 9){
            v9++;
            matrizresultado[8,1] = v9;
        }else if(vetor[i] == 10){
            v10++;
            matrizresultado[9,1] = v10;
        }
    }
    
    for(i = 0; i < 10; i++){
        matrizresultado[i,0] = i + 1;
    }
    Console.Write("politico\tvotos\n");
    for (i = 0; i < 10; i++){
        for (j = 0; j < 2; j++){
            Console.Write("\t{0}", matrizresultado[i, j]);
        }
        Console.WriteLine();
    }
    if(v1>v2 && v1>v3 && v1>v4 && v1>v5 && v1>v6 && v1>v7 && v1>v8 && v1>v9 && v1>v10){
        Console.WriteLine($"o 1° candidato foi vitorioso com {v1} votos ");
    }else if(v2>v1 && v2>v3 && v2>v4 && v2>v5 && v2>v6 && v2>v7 && v2>v8 && v2>v9 && v2>v10){
        Console.WriteLine($"o 2° candidato foi vitorioso com {v2} votos ");
    }else if(v3>v1 && v3>v2 && v3>v4 && v3>v5 && v3>v6 && v3>v7 && v3>v8 && v3>v9 && v3>v10){
        Console.WriteLine($"o 3° candidato foi vitorioso com {v3} votos ");
    }else if(v4>v1 && v4>v2 && v4>v3 && v4>v5 && v4>v6 && v4>v7 && v4>v8 && v4>v9 && v4>v10){
        Console.WriteLine($"o 4° candidato foi vitorioso com {v4} votos ");
    }else if(v5>v1 && v5>v2 && v5>v3 && v5>v4 && v5>v6 && v5>v7 && v5>v8 && v5>v9 && v5>v10){
        Console.WriteLine($"o 5° candidato foi vitorioso com {v5} votos ");
    }else if(v6>v1 && v6>v2 && v6>v3 && v6>v4 && v6>v5 && v6>v7 && v6>v8 && v6>v9 && v6>v10){
        Console.WriteLine($"o 6° candidato foi vitorioso com {v6} votos ");
    }else if(v7>v1 && v7>v2 && v7>v3 && v7>v4 && v7>v5 && v7>v6 && v7>v8 && v7>v9 && v7>v10){
        Console.WriteLine($"o 7° candidato foi vitorioso com {v7} votos ");
    }else if(v8>v1 && v8>v2 && v8>v3 && v8>v4 && v8>v5 && v8>v6 && v8>v7 && v8>v9 && v8>v10){
        Console.WriteLine($"o 8° candidato foi vitorioso com {v8} votos ");
    }else if(v9>v1 && v9>v2 && v9>v3 && v9>v4 && v9>v5 && v9>v6 && v9>v7 && v9>v8 && v9>v10){
        Console.WriteLine($"o 9° candidato foi vitorioso com {v9} votos ");
    }else if(v10>v1 && v10>v2 && v10>v3 && v10>v4 && v10>v5 && v10>v6 && v10>v7 && v10>v8 && v10>v9){
        Console.WriteLine($"o 10° candidato foi vitorioso com {v10} votos ");
    }else{
        Console.WriteLine("empate");
    }
  }
}
