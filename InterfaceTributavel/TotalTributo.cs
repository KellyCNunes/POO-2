using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class TotalTributo
    {
    public double TotalTributos { get; private set; }

    public void AdicionaTributo(Itributavel tributavel)
    {
        TotalTributos += tributavel.CalculaTributos();
    }
    }
}