//metodo main()

using InterfaceAutenticavel;

Cliente c = new Cliente ();
c.Senha  = 123;
//classe abstrata e interface não podem se instanciaveis
IAutenticavel it = c; //it é objeto que contem os metodos em comum entre classes "normais" e interface
Console.WriteLine("Autenticou? " +  it.Autenticar(123));


Diretor d = new Diretor ();
d.Senha = 1234;
IAutenticavel itd = d;
Console.WriteLine("Autenticou? " +  itd.Autenticar(1234));


Gerente g = new Gerente ();
g.Senha = 123456;
IAutenticavel itg = g;
Console.WriteLine("Autenticou? " +  itg.Autenticar(1234));


