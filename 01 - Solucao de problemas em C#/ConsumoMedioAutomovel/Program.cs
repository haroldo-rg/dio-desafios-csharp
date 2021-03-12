﻿/*******************************************************************************
DESAFIO 1/3: Consumo Médio do Automóvel

Você deve calcular o consumo médio de um automóvel onde será informada a 
distância total percorrida (em Km) e o total de combustível consumido 
(em litros).

Entrada
Você receberá dois valores: um valor inteiro X com a distância total percorrida 
(em Km), e um valor real Y que representa o total de combustível consumido, 
com um dígito após o ponto decimal.

Saída
Exiba o valor que representa o consumo médio do automóvel (3 casas após a
 vírgula), incluindo no final a mensagem "km/l".

Exemplo de Entrada	Exemplo de Saída
500                 14.286 km/l
35.0

2254                18.119 km/l
124.4

4554                9.802 km/l
464.6
*******************************************************************************/

using System;

namespace ConsumoMedioAutomovel
{
    class Program
    {
        static void Main(string[] args) { 

                int distancia;
                double combustivelGasto, consumoMedio;

                distancia = Convert.ToInt32(Console.ReadLine());
                combustivelGasto = Convert.ToDouble(Console.ReadLine());

                consumoMedio = distancia / combustivelGasto;

                Console.WriteLine("{0:0.000} km/l", consumoMedio);

        }
    }
}
