using dotnetHelo.Common.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

Console.WriteLine("Percorrendo a lista com for");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com foreach");
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
    contadorForeach++;
}







// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine("percorrendo o array com for") ;
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição número {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("percorrendo o array com foreach") ;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }


// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Helo";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();


// calc.Somar(10, 5);
// calc.Subtrair(10, 5);
// calc.Multiplicar(10, 5);
// calc.Dividir(10, 5);
// calc.Potencia(10, 5);
// calc.Seno(45);
// calc.Cosseno(45);
// calc.Tangente(45);
// calc.RaizQuadrada(9);


// // DateTime dataAtual = DateTime.Now;
// // Console.WriteLine(dataAtual);
// // Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// // dataAtual = DateTime.Now.AddDays(5);
// // Console.WriteLine(dataAtual);

// // string palavra = "15";
// // int b = 0;

// // int.TryParse(palavra, out b);

// // int quantidade1 = 10;
// // int quantidade2 = 4;
// // bool condicao = quantidade1 >= quantidade2;
// // Console.WriteLine(condicao);

// // Console.WriteLine("Digite uma letra: ");
// // string letra = Console.ReadLine();

// // switch (letra)
// // {
// //     case "a":
// //     case "e":
// //     case "i":
// //     case "o":
// //     case "u":
// //         Console.WriteLine(letra);
// //         break;
// //     default:
// //         Console.WriteLine("Não é vogal");
// //         break;
// // }

// // string apresentacao = "Olá, seja bem vindo";

// // int quantidade = 1;
// // Console.WriteLine("Valor da variável quantidade: " + quantidade);

// // quantidade = 10;
// // Console.WriteLine("Valor da variável quantidade: " + quantidade);

// // double altura = 1.60;

// // decimal preco = 1.80M;

// // bool condicao = true;

// // Console.WriteLine(apresentacao);
// // Console.WriteLine("Valor da variável quantidade: " + quantidade);
// // Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// // Console.WriteLine("Valor da variável preco: " + preco);
// // Console.WriteLine("Valor da variável condicao: " + condicao);

// // Pessoa pessoa1 = new Pessoa();

// // pessoa1.Nome = "Helo";
// // pessoa1.Idade = 20;
// // pessoa1.Apresentar();