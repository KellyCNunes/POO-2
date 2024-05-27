using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public interface IAutenticavel
    {
        //assinatura de método: saber pelo nome dele, que ele precisa de parametro e conhecer que ele vai ter retorno, é aquilo que tem dentro da interface, sabe oq ele faz, mas não como faz
        bool Autenticar (int senha);
    }
}