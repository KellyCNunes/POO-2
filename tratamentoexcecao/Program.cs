/*try{
    File.OpenRead("\\teste\\ArquivoLeitura.txt");
}

catch (FileNotFoundException e)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Erro pelo FileNotException");
    System.Console.WriteLine("----------------------------------------------");
    System.Console.WriteLine(e.ToString());
    System.Console.WriteLine();
}

catch (Exception e)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Erro pelo Exception");
    System.Console.WriteLine("----------------------------------------------");
    System.Console.WriteLine(e.ToString());
    System.Console.WriteLine();
}*/



int valor1 = 100, valor2 = 0, total = 0;
try //Bloco onde poderá ocorrer algum erro
{
    total = valor1 / valor2;
}
catch (Exception ex) //Classe responsável pelo tipo de erro
{
    Console.WriteLine("Ocorreu uma exceção na rotina acima! " + ex.Message);
}

System.Console.WriteLine("Término do programa com sucesso!!!");

