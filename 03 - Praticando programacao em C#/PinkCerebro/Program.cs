/*******************************************************************************
DESAFIO 3/3: Pink e Cérebro

Pink e Cérebro dividem um apartamento e estão juntos 24h por dia desde o começo 
da pandemia. Para passar o temp, Pink cria problemas matemáticos para Cérebro 
resolver, o último deles foi uma lista de números com a seguinte pergunta: 
quantos números da lista são múltiplos de 2, 3, 4 e 5?

Apesar de parecer simples, porém, quando a lista contém muitos números, Cérebro 
se confunde e acaba errando alguns cálculos.

Ajude Cérebro a resolver o desadio de Pink.

Entrada
A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), 
representando a quantidade de números na lista de Pink.

A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando os números 
da lista de Pink.

Saída
Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes na lista. 
Observe a formatação da saída nos exemplos, pois ela deve ser seguida
rigorosamente.

Exemplo de Entrada     Exemplo de Saída
5                      4 Multiplo(s) de 2
2 5 4 20 10            0 Multiplo(s) de 3
                       2 Multiplo(s) de 4
                       3 Multiplo(s) de 5

*******************************************************************************/
using System;

namespace PinkCerebro
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] N = new int[] {2, 3, 4, 5};
            int[] QtdeMultiplos = new int[] {0, 0, 0, 0};

            int qdtNumeros = int.Parse(Console.ReadLine());
            string[] entradaNumeros = Console.ReadLine().Split();

            for(int i = 0; i < qdtNumeros; i++)
            {
                int numero = int.Parse(entradaNumeros[i]);

                for(int j=0; j < N.Length; j++)
                    if(numero % N[j] == 0)
                        QtdeMultiplos[j]++;
            }

            for(int i = 0; i < N.Length; i++)
                Console.WriteLine($"{ QtdeMultiplos[i] } Multiplo(s) de { N[i] }");

        }
    }
}
