using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    public class Venda
    {
        private int Data { get; set; }
        private double Total { get; set; }

        public List<ItemVenda> VItens {get; set;}

        public Venda(int data)
        {
            Data = data;
            Total = 0;
            Itens = new List<ItemVenda>();
        }
        public void Mostrar()
            {
                Console.WriteLine("Data: " + Data + "\tTotal: " + Total);
            }

         public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
            Total += item.Subtotal;
        }

        public void Mostrar()
        {
            Console.WriteLine("Data: " + Data + "\tTotal: " + Total);
            foreach (ItemVenda item in Itens)
            {
                item.Mostrar();
            }
        }
    }
}

        public double total
        {
            get{return Total;}
            set{Total = value;}
        }

        public int data
        {
            get{return Data;}
            set{Data = value;}
        }
        public int CalcularTotalItens()
        {
            Console.WriteLine(VItens.Count);
            return VItens.Count;
        }
}
}
