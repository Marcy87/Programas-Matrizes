using System;

namespace ProgramMatrizes03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }


            

            for (int i = 0; i < N; i++)
            {
                int maior = matriz[i, 0];
                for (int j = 1; j < N; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}