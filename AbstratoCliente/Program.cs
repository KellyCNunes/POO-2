// Método Main()

using AbstratoCliente;

//Cliente c = new Cliente();//não instanciará

ClienteFisico cf = new ClienteFisico(1,"Ana","Rua Ana",20,1111);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(100, "Empresa", "Rua Empresa", 43,10000);
cj.Mostrar();

Teste t = new Teste();
t.VerificaIdade(cj);

