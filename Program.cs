using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aulas_C_Sharp.Desafios;

  class Program 
  {
    static void Main(string[] args) 
    {
      int valor1 = int.Parse(Console.ReadLine());
      int valor2 = int.Parse(Console.ReadLine());
      int valor3 = int.Parse(Console.ReadLine());
      int valor4 = int.Parse(Console.ReadLine());
      int valor5 = int.Parse(Console.ReadLine()); 

      int quantidadePares = 0;
      int quantidadeImpares = 0;
      int quantidadePositivos = 0;
      int quantidadeNegativos = 0;

    int[] valores = new int[] {valor1, valor2, valor3, valor4, valor5};

    for (int contador = 0; contador < valores.Length; contador++)
    {
        if (valores[contador] % 2 == 0)
        {
            quantidadePares += 1;
        } 
        else 
        {
            quantidadeImpares += 1;
        }
        if (valores[contador] > 0)
        {
            quantidadePositivos += 1;
        } 
        else if (valores[contador] < 0)
        {
            quantidadeNegativos += 1;
        }
     }

Console.WriteLine("{0} par(es)", quantidadePares);
Console.WriteLine("{0} impar(es)", quantidadeImpares);
Console.WriteLine("{0} positivo(s)", quantidadePositivos);
Console.WriteLine("{0} negativo(s)", quantidadeNegativos);
        }
    }
