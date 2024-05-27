
using InterfaceTributavel;

public class Program
{
        ContaCorrente contaCorrente = new ContaCorrente(1000);
        SeguroVida seguroVida = new SeguroVida();

        Console.WriteLine($"Tributo da Conta Corrente:  {contaCorrente.CalculaTributos()}");
        Console.WriteLine($"Tributo do Seguro de Vida: {seguroVida.CalculaTributos()}");

        TotalTributos totalizador = new TotalTributos();
        totalizador.AdicionaTributo(ContaCorrente);
        totalizador.AdicionaTributo(SeguroVida);

        Console.WriteLine($"Total de tributos acumulados: {totalizador.TotalTributos}");
}
 
