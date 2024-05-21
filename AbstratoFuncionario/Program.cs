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
//d2.Demitir(4);
//d2.ListarFuncionarios();

Dependente de1 = new Dependente (1, "Nataly", 12);
a1.Adicionar(de1);
Dependente de2 = new Dependente (2, "Marcus", 20);
a2.Adicionar(de2);

