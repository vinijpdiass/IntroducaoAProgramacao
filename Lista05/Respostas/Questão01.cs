using System;
class equacaodosegundograu {
  static double[] raiz(double a, double b, double c){
    double delta = 0, x1 = 0, x2 = 0, status = 0;
    delta = (b * b) - (4 * a * c);
    
    if (delta > 0){
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        status = 2;
        double[] saidas = new double[3]{x1, x2, status};
        return saidas;
    }else if(delta == 0){
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        status = 1;
        double[] saidas = new double[3]{x1, 0, status};
        return saidas;
    }else{
        status = 0;
        double[] saidas = new double[3]{0, 0, status};
        return saidas;
    }

  }
  static void Main() {
    double a, b, c, delta, x1, x2; 
    double [] saida = new double[3];
    Console.WriteLine("escreva o valor de a, b e c");
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    c = double.Parse(Console.ReadLine());
    
    if (a == 0){
        Console.WriteLine("o valor de a não pode ser 0\nEscreva um novo valor");
        a = double.Parse(Console.ReadLine());
    }
    
    saida = raiz(a, b, c);
    
    Console.WriteLine($"O status é {saida[2]}, o valor de x1 é {saida[0]} e o valor de x2 é {saida[1]}");

  }
}
