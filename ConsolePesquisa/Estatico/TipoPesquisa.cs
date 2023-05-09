namespace ConsolePesquisa.Estatico

    public static class TipoPesquisa{

        public static int Linear(out TipoDicionario dicionario, out passosLinear, out TipoChave chave ){
            passosLinear = 0;
            for (int i = 1; i <= dicionario.Tamanho(); i++)
            {
                passosLinear++;
                if (dicionario.Elemento(i) == chave)
                {
                    return i;
                }
            }
            return -1;
            }
    }
