public class Carros : Veiculos
{
    public int Portas { get; set; }
    public int Bagageiro { get; set; }

    public Carros(int portas, int bagageiro, string descricao, string nomeMarca, int anoFabricacao, double valorAluguel, double qtdDias) : base(descricao, nomeMarca, anoFabricacao, valorAluguel, qtdDias)
    {
        Portas = portas;
        Bagageiro = bagageiro;
    }

    public override double CalcularAluguel(int _qntDias)
    {
        double valor = 0;
        if (valor > 7)
            valor += (_valorAluguel * _qntDias) / 0.10;

        return _valorAluguel;
    }
}