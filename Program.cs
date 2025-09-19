using dotnetHelo.Models;

Pessoa pessoa1 = new Pessoa();

// nome de variável é Camel Case -> começa com minúscula e palavras compostas são escritas juntas sem espaços, com a primeira letra de cada palavra subsequentemente capitalizada
// sem caractere especial nos nomes, apenas underline é aceito

// tipos de dados:
// string = série de caracteres
// char = um único caractere
// object = objeto
// bool = booleano (true or false)
// int = números inteiros (ele tem limite mas é alto)
// uint = a diferença entre int e uint é que uint usa os 32 bits pra representar numeros positivos
// long = inteiros que vão mais longe que int
// ulong é de 64 bit (o dobro de uint e é só positivos)
// byte vai de 0 a 255
// para números decimais:
// decimal é recomendável quando é dinheiro, é mais preciso quando se tem valores monetários
// float é para os decimais como o int é para os inteiros
// double é para os decimais como o long é para os inteiros
// principais utilizados: string, object, bool, int, decimal e double

pessoa1.Nome = "Helo";
pessoa1.Idade = 20;
pessoa1.Apresentar();