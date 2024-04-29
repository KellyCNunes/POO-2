
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Produto
    {
        protected int codigo;
        protected string nome;
        protected double preco;

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public int Codigo
        {
            get {return codigo;}
            set { codigo = value;}
        
        }

        public string Nome
        {
            get { return nome;}
            set { nome = value;}
        }

        public double Preco{
            get { return preco;}
            set { preco = value;}
        }

    }
}