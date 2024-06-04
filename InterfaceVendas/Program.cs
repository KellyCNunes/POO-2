

using InterfaceVendas;
/*public class IniciarMenu
{
    public void MenuIniciar()
    {
        Menu menu = new Menu();
        menu.Iniciar();
    }
}*/

 List<Produto> produtos = new List<Produto>();
 List<Venda> vendas = new List<Venda>();



        int opcao = 0;
        while (opcao != 7)
        {
            System.Console.WriteLine(("Menu:"));
            System.Console.WriteLine("1 - Cadastrar Produto:");
            System.Console.WriteLine("2 - Registrar Venda");
            System.Console.WriteLine("3 - Consultar Venda");
            System.Console.WriteLine("4 - Forma de Pagamento (Cartão)");
            System.Console.WriteLine("5 - Forma de Pagamento (Cheque)");
            System.Console.WriteLine("6 - Forma de Pagamento (Espécie)");
            System.Console.WriteLine("7 - Sair\nDigite a opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());
        }
    

