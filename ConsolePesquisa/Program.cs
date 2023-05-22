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

        public static void Inicializar(out TipoDicionario dicionario)
        {
                       dicionario = new TipoDicionario();
                       dicionario.elementos = new string[100];
                       dicionario.tamanho = 0;
        }

        public static void Insere(ref TipoDicionario dicionario, int posicao, string elemento)
        {
            dicionario.elementos[posicao] = elemento;
            dicionario.tamanho++;
        }

        public static int PesquisaLinear(TipoDicionario dicionario, string elemento, out int passos)
        {
            passos = 0;
            for (int i = 0; i < dicionario.tamanho; i++)
            {
                passos++;
                if (dicionario.elementos[i] == elemento)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            TipoDicionario dicionario;
            
            Inicializar(out dicionario);

            // Adicionar elementos ao dicionário
            Insere(ref dicionario, 0, "abc");
            Insere(ref dicionario, 1, "jkl");
            Insere(ref dicionario, 2, "ghi");
            Insere(ref dicionario, 3, "def");



            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento foi fornecido. Pesquisa não realizada.");
            }
            else
            {
                int passosLinear, passosBinaria;
                Console.WriteLine("Argumentos fornecidos:");
                foreach (string argumento in args)
                {
                    Console.WriteLine(argumento);
                    int posicaoLinear = PesquisaLinear(dicionario, argumento, out passosLinear);
                    Console.WriteLine("Pesquisa Linear:");
                    if (posicaoLinear != -1)
                    {
                        Console.WriteLine("Elemento encontrado na posição {0}.", posicaoLinear);
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado.");
                    }
                    Console.WriteLine("Número de passos: {0}", passosLinear);
                                    
                }
            }
        }
    }
}
