using System;

namespace ConsolePesquisa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorNaoOrdenado = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < vetorNaoOrdenado.Length; i++)
            {
                vetorNaoOrdenado[i] = rnd.Next(1, 1051);
            }


            int[] vetorOrdenado = vetorNaoOrdenado;

            Array.sort(vetorOrdenado);
    }
}
