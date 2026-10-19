using PilaresPOO.Exercicios;
using PilaresPOO;

//Carro carro1 = new Carro("ferrari","Hb20");

//Console.WriteLine(carro1.Marca); Console.WriteLine(carro1.Modelo);

//// Metodo Construtor - Obriga o objeto a ser criado de uma forma
//// Pilares da POO

//// Evitar estados inválidos

//ContaBancaria conta1 = new ContaBancaria();

//conta1.Saldo = -500;
//Console.WriteLine("seu saldo é de: " + conta1.Saldo);

//ex A1 > Livro

Livro livro1 = new Livro($"Turma da Mônica","Mauricio de Souza",42);
Livro livro2 = new Livro($"Harry Potter", "JK Howling", 155);

livro1.Exibir();
livro2.Exibir();

//ex A2 > Viagem

Viagem viagem1 = new Viagem("Japão",20,400);
Viagem v1 = new Viagem("Salvador", 5, 200);
Viagem v2 = new Viagem("Gramado", 3, 350);
viagem1.Exibir();
v1.Exibir();
v2.Exibir();

//ex A3 > Contato

Contato c1 = new Contato("Ana", "(11) 99999-0000", "ana@email.com");
Contato c2 = new Contato("Bruno", "(21) 98888-1111");

c1.Exibir();
c2.Exibir();

//Lista: Encapsulamento
//ex B1 Contador de Visitas

//ENCAPSULAMENTO (private, public) (get, set)
// get -> 

ContadorDeVisitas contador = new ContadorDeVisitas();

contador.RegistrarVisita();
contador.RegistrarVisita();
contador.RegistrarVisita();

Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");

//ex B2

Boletim boletim = new Boletim();
boletim.Aluno = "Ana";

boletim.DefinirNota(8.5);
boletim.DefinirNota(15);

Console.WriteLine($"{boletim.Aluno}: nota {boletim.ObterNota()}");

//ex B3

//Usuário usuario = new Usuário("ana123", "segredo");

//Console.WriteLine(usuario.ConferirSenha("1234"));
//Console.WriteLine(usuario.ConferirSenha("segredo"));

//usuario.TrocarSenha("errada", "novaSenha");
//usuario.TrocarSenha("segredo", "novaSenha");

//Console.WriteLine(usuario.ConferirSenha("novaSenha"));

//HERANÇA   
//*reaproveitar o código

Aluno aluno = new Aluno();
Professor professor = new Professor();

aluno.Idade = 20;
aluno.Nome = "Vinicio";
professor.Idade = 40;
professor.Nome = "Lucas";

aluno.Apresentar();
professor.Apresentar();

//ex C1

Cachorro cachorro = new Cachorro();
cachorro.Nome = "Rex";

cachorro.Comer();
cachorro.Latir();

//ex C2

Funcionario ana = new Funcionario("Ana", 3000);
Gerente carlos = new Gerente("Carlos", 5000, 1500);

Console.WriteLine($"{ana.Nome}: R$ {ana.Salario:F2}");
Console.WriteLine($"{carlos.Nome}: R$ {carlos.Salario:F2} + bônus = R$ {carlos.SalarioComBonus():F2}");

// ex C3

CarroA carro = new CarroA("Fiat", "Uno", 4);
MotoB moto = new MotoB("Honda", "CG 160", 160);

carro.Exibir();
carro.ExibirPortas();
moto.Exibir();
moto.ExibirCilindradas();

//polimorfismo 

//ex D1

Saudacao s = new Saudacao();

s.Cumprimentar();
s.Cumprimentar("Ana");
s.Cumprimentar("Bruno", 25);

//ex D2

CalculadoraDeArea calc = new CalculadoraDeArea();

Console.WriteLine($"Quadrado: {calc.CalcularArea(5)}");
Console.WriteLine($"Retângulo: {calc.CalcularArea(15, 2)}");

//ex D3
Instrumento instrumento = new Instrumento();
Violao violao = new Violao();

instrumento.Tocar();
violao.Tocar();