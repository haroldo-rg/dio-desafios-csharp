﻿/*******************************************************************************
DESAFIO 3/3: Aumento de Salário

A empresa ABC resolveu conceder um aumento de salários a seus funcionários de 
acordo com a tabela abaixo:


Salário                Percentual de Reajuste
   0.00  -  400.00                        15%  
 400.01  -  800.00                        12%
 800.01  - 1200.00                        10%
1200.01  - 2000.00                         7%
  Acima de 2000.00                         4%


Leia o salário do funcionário e calcule e mostre o novo salário, bem como o 
valor de reajuste ganho e o índice reajustado, em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou 
igual a zero, com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o
percentual de reajuste ganho, conforme exemplo abaixo.

Exemplo de Entrada     Exemplo de Saída
400.00                 Novo salario: 460.00
                       Reajuste ganho: 60.00
                       Em percentual: 15 %

800.01                 Novo salario: 880.01
                       Reajuste ganho: 80.00
                       Em percentual: 10 %

2000.00                Novo salario: 2140.00
                       Reajuste ganho: 140.00
                       Em percentual: 7 %
*******************************************************************************/
using System;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args) { 

            double[,] faixas = new double[,]
            { 
                {      -1,  400.00, 15.0 }, 
                {  400.00,  800.00, 12.0 }, 
                {  800.00, 1200.00, 10.0 }, 
                { 1200.00, 2000.00,  7.0 }, 
                { 2000.00, Double.MaxValue, 4.0 }
            };
            
            double salario = Convert.ToDouble(Console.ReadLine());
            int qtdFaixas = faixas.Length / (faixas.Rank+1);
            double reajuste, novoSalario;

            for(int i = 0; i < qtdFaixas; i++)
            {
                if(salario > faixas[i, 0] && salario <= faixas[i, 1])
                {
                    reajuste = salario * faixas[i, 2] / 100;
                    novoSalario = salario + reajuste;
                    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                    Console.WriteLine("Em percentual: {0} %", faixas[i, 2]);

                    break;
                }
            }
        }       
    }
}