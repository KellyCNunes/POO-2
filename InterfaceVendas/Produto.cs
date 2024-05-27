using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private int Estoque { get; set; }
        private double Preco { get; set; }
    }
}