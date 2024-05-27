
using InterfaceTributavel;


        ContaCorrente contaCorrente = new ContaCorrente(1000);
        SeguroVida seguroVida = new SeguroVida();

        Console.WriteLine("Tributo da Conta Corrente: " + contaCorrente.CalculaTributos());
        Console.WriteLine("Tributo do Seguro de Vida: " + seguroVida.CalculaTributos());

        TotalTributo totalizador = new TotalTributo();
        totalizador.AdicionaTributo(contaCorrente);
        totalizador.AdicionaTributo(seguroVida);

        Console.WriteLine($"Total de tributos acumulados: {totalizador.TotalTributos}");
