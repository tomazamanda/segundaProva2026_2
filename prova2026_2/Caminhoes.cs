public class Caminhoes : Veiculos
{
    public int QntdEixos { get; set; }
    public int CapacidadeCarga { get; set; }
    public string TipoCarroceria { get; set; }
    public int Comprimento { get; set; }
    public int Altura { get; set; }

    public Caminhoes(int qntdEixos, int capacidadeCarga, string tipoCarroceria, int comprimento, int altura, string descricao, string nomeMarca, int anoFabricacao, double valorAluguel, double qntDias) : base(descricao, nomeMarca, anoFabricacao, valorAluguel, qntDias)
    {
        QntdEixos = qntdEixos;
        CapacidadeCarga = capacidadeCarga;
        TipoCarroceria = tipoCarroceria;
        Comprimento = comprimento;
        Altura = altura;
    }

    public override double CalcularAluguel(int _qntDias)
    {
        double valor = 0;
        if (valor > 10000)
            valor += (_valorAluguel * _qntDias) * 0.20;

        return _valorAluguel;
    }
}