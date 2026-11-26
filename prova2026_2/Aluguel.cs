public class Aluguel
{
    public Veiculos Veiculo { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set;  }
    public int TotalDias { get; set; }
    public double TotalAluguel { get; set; }

    public Aluguel(Veiculos veiculo, DateTime dataInicio, DateTime dataFim, int totalDias, double totalAluguel)
    {
        Veiculo = veiculo;
        DataInicio = dataInicio;
        DataFim = dataFim;
        TotalDias = totalDias;
        TotalAluguel = totalAluguel;

        TotalDias = (DataFim - DataInicio).Days;

        if (DataInicio >= DataFim)
            throw new Exception("A data de fim deve ser posterior a data de início, revise as datas informadas!");
    }

    public double CalcularTotalAluguel()
    {
        double valor = 0;
        TotalAluguel = Veiculo.CalcularAluguel(TotalDias);
        return valor;
    }
}