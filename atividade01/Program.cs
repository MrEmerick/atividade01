using atividade01;
using atividade01.model;

Produto produto1 = new Produto(100, "Sacola");

Console.WriteLine($"produto {produto1.Nome} é R${produto1.Preço}");
Console.WriteLine($"O produto mais caro é {produto1.ProdutoMaisCaro}");
Cliente cliente1 = new Cliente("Fred", "12343232111","RJ");


produto1.Dados = cliente1;
Console.WriteLine($"cliente : {cliente1.Nome} do cpf {cliente1.Cpf} da cidade de {cliente1.Cidade}");
Console.WriteLine( $"{produto1.Comprar(120)}" );
