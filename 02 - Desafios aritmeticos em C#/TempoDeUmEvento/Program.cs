/*******************************************************************************
DESAFIO 4/5: Tempo de um Evento

Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no 
mês de Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho 
quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia 
e quando termina o evento.

Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá 
ajudar Pedrinho a calcular a duração deste evento.

Entrada
Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um 
espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será 
informado o momento no qual o evento vai iniciar, no formato hh : mm : ss. 
Na terceira e quarta linha de entrada haverá outra informação no mesmo formato
 das duas primeiras linhas, indicando o término do evento.

Saída
Na saída, deve ser apresentada a duração do evento, no seguinte formato:

W dia(s)
X hora(s)
Y minuto(s)
Z segundo(s)

Obs: Considere que o evento do caso de teste para o problema tem duração mínima 
de 1 minuto.

Exemplo de Entrada        Exemplo de Saída
Dia 5                     3 dia(s)
08 : 12 : 23              22 hora(s)
Dia 9                     1 minuto(s)
06 : 13 : 23              0 segundo(s)
*******************************************************************************/

using System;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIA = 86400, HORA = 3600, MINUTO = 60;

            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);

            int transformaSegundosInicio  = (diaInicio  * DIA + horaMomentoInicio  * HORA + minutoMomentoInicio  * MINUTO + segundoMomentoInicio);
            int transformaSegundosTermino = (diaTermino * DIA + horaMomentoTermino * HORA + minutoMomentoTermino * MINUTO + segundoMomentoTerminio);

            int somaTotalSegundos = (transformaSegundosTermino - transformaSegundosInicio);

            int W = (int)(somaTotalSegundos / DIA); 
            somaTotalSegundos -= W * DIA;

            int H = (int)(somaTotalSegundos / HORA);
            somaTotalSegundos -= H * HORA;

            int M = (int)(somaTotalSegundos / MINUTO);
            somaTotalSegundos -= M * MINUTO;

            int S = somaTotalSegundos;

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", H);
            Console.WriteLine("{0} minuto(s)", M);
            Console.WriteLine("{0} segundo(s)", S);

        }
    }
}
