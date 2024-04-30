using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Funcionario", 1000);
System.Console.WriteLine("Bonificação do funcionario: " + f.CalcularBonificacao());

Secretario s = new Secretario(2, "secretario", 1000);
System.Console.WriteLine("Bonificação do secretario: " + s.CalcularBonificacao());

Gerente g = new Gerente(3, "gerente", 1000);
System.Console.WriteLine("Bonificação do gerente: " + g.CalcularBonificacao());

Diretor d = new Diretor(4, "diretor", 1000);
System.Console.WriteLine("Bonificação do diretor: " + d.CalcularBonificacao());