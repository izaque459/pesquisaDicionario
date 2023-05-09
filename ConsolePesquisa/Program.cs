using System;

namespace ConsolePesquisa
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoDicionario dicionarioNaoOrdenado = new TipoDicionario();
            dicionarioNaoOrdenado.Inicializa();
            Random rnd = new Random();
            for (int i = 1; i < NumReg.Maximo; i++)
            {
                dicionarioNaoOrdenado.Insere(rnd.Next(1, 1051));
            }


            
            if (args.Length == 0)
            {
                 Console.WriteLine("Nenhum argumento foi fornecido.");
            }else{
                int passosLinear, passosBinaria;

                int posicaoLinear = TipoPesquisa.Linear(out dicionarioNaoOrdenado, out passosLinear, out elemento);
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
