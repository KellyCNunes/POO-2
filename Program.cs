﻿// See https://aka.ms/new-console-template for more information
using heranca;

Produto p = new Produto();
p.Mostrar();
Produto p1 = new Produto(1, "mouse", 50);
p1.Mostrar();

Perecivel pe = new Perecivel();
pe.Mostrar();
Perecivel pe2 = new Perecivel(2, "lanche", 21, "28/04/2024", "29/04/2024", 22);
pe2.Mostrar();