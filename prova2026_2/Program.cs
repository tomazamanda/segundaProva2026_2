try
{
    Carros c = new Carros(4, 20, "fiat", "vermelho", 2026, 20, 10);
    c._valorAluguel = 100;
    Console.WriteLine(c.CalcularAluguel(20));

    Aluguel a = new Aluguel(c, new DateTime(2026, 11, 01), new DateTime(2026, 11, 11),10,0);
    Console.WriteLine(a.CalcularTotalAluguel());

    Motos m = new Motos(80, "partida elétrica", 50, 20, "vermelha", "honda", 2205, 40, 2);
    m._valorAluguel = 40;
    Console.WriteLine(m.CalcularAluguel(40));

    Caminhoes ca = new Caminhoes(8, 70, "grande", 40, 100, "rosa", "yamaha", 2020, 400, 7);
    ca._valorAluguel = 400;
    Console.WriteLine(ca.CalcularAluguel(400));
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}