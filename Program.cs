using dotnetHelo.Models;

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// double altura = 1.60;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Helo";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();