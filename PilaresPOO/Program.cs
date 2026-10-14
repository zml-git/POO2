
using PilaresPOO;

//Carro carro1 = new Carro("ferrari","Hb20");

//Console.WriteLine(carro1.Marca); Console.WriteLine(carro1.Modelo);

//// Metodo Construtor - Obriga o objeto a ser criado de uma forma
//// Pilares da POO

//// Evitar estados inválidos

//ContaBancaria conta1 = new ContaBancaria();

//conta1.Saldo = -500;
//Console.WriteLine("seu saldo é de: " + conta1.Saldo);

//ex 1 > Livro

Livro livro1 = new Livro($"Turma da Mônica","Mauricio de Souza",42);
Livro livro2 = new Livro($"Harry Potter", "JK Howling", 155);

livro1.Exibir();
livro2.Exibir();

//ex 2 > Viagem

Viagem viagem1 = new Viagem("Japão",20,400);
Viagem v1 = new Viagem("Salvador", 5, 200);
Viagem v2 = new Viagem("Gramado", 3, 350);
viagem1.Exibir();
v1.Exibir();
v2.Exibir();

//ex 3 > Contato

Contato c1 = new Contato("Ana", "(11) 99999-0000", "ana@email.com");
Contato c2 = new Contato("Bruno", "(21) 98888-1111");

c1.Exibir();
c2.Exibir();

//Lista: Encapsulamento
//ex 1 Contador de Visitas

ContadorDeVisitas contador = new ContadorDeVisitas();

