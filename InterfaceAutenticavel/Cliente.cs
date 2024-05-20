using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    //a classe cliente IMPLEMENTA a interface IAUTENTICAVEL

    public int senha { get; set; }
    public class Cliente : InterfaceAutenticavel
    {
        if (Senha == senha)
        {
            Console,WriteLine("client autenticado!");
            return true;
        }
        return false;
    }
}