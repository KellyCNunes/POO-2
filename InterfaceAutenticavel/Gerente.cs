using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Gerente : Funcionario, InterfaceAutenticavel
    {
        public bool Autenticar (int senha)
        {
            if (senha == senha)
            {
                Console.WriteLine("Gerente autenticado!");
                return true;
            }
            return false;
        }
    }
}