using System;

namespace ConsolePesquisa
{
    class Program
    {
        public struct TipoDicionario
        {
            public string[] elementos;
            public int tamanho;
        }

        public static void Inicializar(ref TipoDicionario dicionario)
        {
            dicionario.elementos = new string[dicionario.tamanho];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
