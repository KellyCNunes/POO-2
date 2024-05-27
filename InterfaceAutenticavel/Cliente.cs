using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    //a classe cliente IMPLEMENTA a interface IAUTENTICAVEL

    public class Cliente : IAutenticavel
    
    {
        public int Senha { get; set; }
        public bool Autenticar (int senha)
        {
        if (Senha == senha)
        {
            Console.WriteLine("cliente autenticado!");
            return true;
        }
        return false;
    }
    }
}