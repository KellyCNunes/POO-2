using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao { get; set; }
        private int resultadoTransacao { get; set; }

        public Cartao() : base()
        {         }

        public Cartao (int data, double total, string dadosTransacao, int resultadoTransacao) : base (data, total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }


        //classe base= super classe= classe pai = classe mae
        //classe filho = classe derivada = subclasse
        public override void Mostrar()
        {
            base.Mostrar(); //base()-- chama construtor da classe base, agora base. ---- chama método da classe base (base.Metodo();)
            Console.WriteLine("Data de Transacao: " + DadosTransacao + "\tResultado da Transacao: " +  ResultadoTransacao);
        }

        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }

        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }

    }
}