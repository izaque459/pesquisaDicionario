
namespace ConsolePesquisa.Classes;

public class TipoDicionario
{
    
    public Registro[] Item = new Registro[NumReg.Maximo + 1];
    public int n;
    
    public void Inicializa()
    {
        n = NumReg.Minimo;
    }

    public void Insere(Registro reg)
    {
        if (n == NumReg.Maximo)
        {
            Console.WriteLine("Erro: Dicionario cheio");
        }
        else
        {
            n++;
            Item[n] = reg;
        }
    }
    public int Tamanho(){
        return n;
    }

    public Chave Elemento(int i){
        if(i>NumReg.Minimo)&&(i<=NumReg.Maximo)
                return Registro[i].Chave;
        else
            return Registro[0].Chave;
    }
}
