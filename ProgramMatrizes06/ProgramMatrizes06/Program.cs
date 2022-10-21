using System;
using System.Globalization;

namespace ProgramMatrizes06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[,] matriz = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());


            //Calcular e imprimir a soma de todos os elementos positivos da matriz.
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] > 0.0)
                    {
                        soma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));


            //Fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();


            //Fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();


            //Imprimir os elementos da diagonal principal da matriz.
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();


            //Alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0.0)
                    {
                        matriz[i, j] = matriz[i, j] * matriz[i, j];
                        Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    } else
                    {
                        Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}