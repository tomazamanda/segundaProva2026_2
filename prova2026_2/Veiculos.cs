public abstract class Veiculos
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public string NomeMarca { get; set; }
    public int AnoFabricacao { get; set; }
    public double _valorAluguel;
    public double _qntDias;

    public virtual double CalcularAluguel(int qntDias)
    {
        return _valorAluguel;
    }

    protected Veiculos(string descricao, string nomeMarca, int anoFabricacao, double valorAluguel, double qntDias)
    {
        Descricao = descricao;
        NomeMarca = nomeMarca;
        AnoFabricacao = anoFabricacao;
        _valorAluguel = valorAluguel;
        _qntDias = qntDias;
    }

    public double GetValorAluguel()
    {
        return _valorAluguel;
    }

    public void SetValorAluguel(double valorAluguel)
    {
        double valor = 0;

        if (valor < 0)
            throw new Exception("O valor da diária deve ser igual ou maior que zero!");
    }       
}