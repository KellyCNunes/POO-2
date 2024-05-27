// Método Main()
using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Teo", 1000, 20);
Comissionado c2 = new Comissionado(4, "Tais", 1000, 30);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();
Console.WriteLine($"Total {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionarios();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");


Dependente de1 = new Dependente (1, "Nataly", 12);
a1.Adicionar(de1);
a1.Excluir(de1);
a1.ListarDependente();
Dependente de2 = new Dependente (2, "Marcus", 20);
a2.Adicionar(de2);
a2.Excluir(de2);
a2.ListarDependente();
Dependente de3 = new Dependente (1, "Kelly", 12);
c1.Adicionar(de3);
c1.Excluir(de3);
c1.ListarDependente();
Dependente de4 = new Dependente (1, "Henry", 12);
c2.Adicionar(de4);
c2.Excluir(de4);
c2.ListarDependente();






