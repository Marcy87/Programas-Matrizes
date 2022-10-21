using System;
using System.Net;

namespace ProgramMatrizes07
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[M,N];


            // leitura dos dados de entrada
            for (int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());

            // como nossa matriz comeca na linha 0, vamos decrementar o valor da fila
            fila = fila - 1;

            // passo 1: vamos salvar o ultimo da fila escolhida
            int ultimoDaFila = matriz[fila, N - 1];


            // passo 2: vamos mover todos da fila (menos o ultimo) para a direita,
            // mas teremos que fazer isso da direita para a esquerda (contagem decrescente)
            for (int j = N - 1; j > 0; j--)
            {
                matriz[fila, j] = matriz[fila, j - 1];
            }

            // passo 3: armazenar o ultimo na primeira posicao da fila
            matriz[fila, 0] = ultimoDaFila;


            //Agora vamos imprimir a matriz alterada
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}