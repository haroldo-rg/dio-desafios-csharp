/*******************************************************************************
DESAFIO 1/3: Coordenadas de um Ponto

Leia 2 valores com uma casa decimal (x e y), que devem representar as 
coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao 
qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem 
(x = y = 0).

        |y
   Q2   |   Q1
        |
--------+--------
        |       x
   Q3   |   Q4
        |

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme 
for a situação.

Entrada
A entrada contem as coordenadas de um ponto.

Saída
A saída deve apresentar o quadrante em que o ponto se encontra.

Exemplo de Entrada      Exemplo de Saída
4.5 -2.2                Q4

0.1 0.1                 Q1

0.0 0.0                 Origem

*******************************************************************************/
using System;

namespace CoordenadasDeUmPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split();
            double x = double.Parse(coordenadas[0]), 
                   y = double.Parse(coordenadas[1]);

            string resultado = String.Empty;

            if(x == 0 && y == 0)
                resultado = "Origem";
            else if(x == 0)
                resultado = "Eixo Y";
            else if(y == 0)
                resultado = "Eixo X";
            else if(x > 0 && y > 0)
                resultado = "Q1";
            else if(x < 0 && y > 0)
                resultado = "Q2";
            else if(x < 0 && y < 0)
                resultado = "Q3";
            else
                resultado = "Q4";

            Console.WriteLine(resultado);
        }
    }
}
