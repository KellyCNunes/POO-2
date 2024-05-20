using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Diretor : Funcionario, InterfaceAutenticavel
    {
        if (Senha == senha)
        {
           Console.WriteLine("Diretor autenticado!");
           return true;
        }
        return false;
    }
}