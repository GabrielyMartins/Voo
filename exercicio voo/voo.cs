
public class Voo
{
    private DateTime dataHora;
    private int numeroVoo;
    public bool[] passageiros = new bool[100];

    public Voo(DateTime dataHora, int numeroVoo)
    {
        this.dataHora = dataHora;
        this.numeroVoo = numeroVoo;
    }
    public DateTime GetDataHora()
    {
        return this.dataHora;
    }

    public int GetNumeroVoo()
    {
        return this.numeroVoo; 
    }

    public void SetDataHora(DateTime dataHora) 
    { 
        this.dataHora = dataHora;
    }

    public void SetVoo(int numeroVoo) 
    {
        this.numeroVoo = numeroVoo;
    }

    public int ProximoLivre()
    {
        for (int i = 0; i < passageiros.Length; i++)
        {
            if (passageiros[i] == false)
            {
                return i;
                break;
            }
        }
        Console.WriteLine("Infelizmente não tem poltronas livres.");
        return -1;
    }

    public bool Ocupar(int nCadeira)
    {
        if (this.passageiros[nCadeira] == false)
        {
            this.passageiros[nCadeira] = true;

            Console.WriteLine("Essa poltrona está dispónivel");
            return true;
        }
        else
        {
            Console.WriteLine("Poltrona já está ocupada!");
            return false;
        }
    }

    public bool Verificar(int nCadeira)
    {
        if (this.passageiros[nCadeira] == false) 
        {
            Console.WriteLine("Poltrona disponível");
            return true;
        }
        else
        {
            Console.WriteLine("Poltrona ocupada!");
            return false; 
        }   
    }

    public int Vagas()
    {
        int cont = 0;
        for(int i = 0;i < passageiros.Length;i++) 
        { 
            if (this.passageiros[i] == false)
            {
                cont +=1;
            }
        }
        return cont;
    }
   
}
