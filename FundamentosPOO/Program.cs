

// Classe Pedido
// NomeDoCliente, Item, Quantidade, Preco
//// Objetos
////ctrl .
//using semana_4;

//Pedido pedido1 = new Pedido();

////string item = "X-Burguer";
////pedido1.Item = "X-Burguer";

//Console.WriteLine("Digite o nome do item: ");
//pedido1.Item = Console.ReadLine();

//Console.WriteLine("Digite o nome do cliente: ");
//pedido1.NomeDoCliente = Console.ReadLine();

//Console.WriteLine("Digite a quantidade: ");
//pedido1.Quantidade = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o preco: ");
//pedido1.Preco = double.Parse(Console.ReadLine());

////ex
//Console.WriteLine(pedido1.Item);
//Console.WriteLine(pedido1.NomeDoCliente);
//Console.WriteLine(pedido1.Quantidade);
//Console.WriteLine(pedido1.Preco);



///Lista 1: Classes e Objetos
//ex 1  

using semana_4;

Pessoa Apresentar = new Pessoa();
Pessoa Apresentar2 = new Pessoa();


Apresentar.Nome = "Ricardo";
Apresentar2.Nome = "Ana";

Apresentar.Idade = int.Parse("35");
Apresentar2.Idade = int.Parse("20");

Console.WriteLine($"Olá, meu nome é {Apresentar.Nome} e tenho {Apresentar.Idade} anos");
Console.WriteLine($"Olá, meu nome é {Apresentar2.Nome} e tenho {Apresentar2.Idade} anos");

//ex 2

Retangulo ret = new Retangulo();
ret.Altura = 5;
ret.Largura = 3;
double resultadoArea = ret.CalcularArea();
Console.WriteLine("area: " + resultadoArea);
double resultadoPerimetro = ret.CalcularPerimetro();
Console.WriteLine("perimetro: " + resultadoPerimetro);

//ex 3


///Lista 2: Classes e Métodos
//ex 1

Pessoa ana = new Pessoa();
ana.Nome = "Ana";

ana.Cumprimentar();
ana.CumprimentarAlguem("Bruno");

string frase = ana.ObterApresentacao();
Console.WriteLine(frase);

//ex 2

//muito que bem
Console.WriteLine("github teste");