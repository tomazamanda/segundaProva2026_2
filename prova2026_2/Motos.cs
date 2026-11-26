public class Motos : Veiculos
{
    public int Cilindrada { get; set; }
    public string PartidaEletrica { get; set; }
    public int Peso { get; set; }
    public int CapacidadeTanque { get; set; }

    public Motos(int cilindrada, string partidaEletrica, int peso, int capacidadeTanque, string descricao, string nomeMarca, int anoFabricacao, double valorAluguel, double qtdDias) : base(descricao, nomeMarca, anoFabricacao, valorAluguel, qtdDias)
    {
        Cilindrada = cilindrada;
        PartidaEletrica = partidaEletrica;
        Peso = peso;
        CapacidadeTanque = capacidadeTanque;
    }

    public override double CalcularAluguel(int _qntDias)
    {
        double valor = 0;
        if (valor > 5)
            valor += (_valorAluguel * _qntDias) / 0.15;

        return _valorAluguel;
    }
}