﻿using System;

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

        public static void Insere(ref TipoDicionario dicionario, int posicao, string elemento)
        {
            dicionario.elementos[posicao] = elemento;
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
            Console.WriteLine("Hello World!");
        }
    }
}
