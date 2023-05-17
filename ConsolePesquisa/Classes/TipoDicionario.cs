
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
}
