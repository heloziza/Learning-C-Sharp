using dotnetHelo.Models;

Pessoa pessoa1 = new Pessoa();

// nome de variável é Camel Case -> começa com minúscula e palavras compostas são escritas juntas sem espaços, com a primeira letra de cada palavra subsequentemente capitalizada
// sem caractere especial nos nomes, apenas underline é aceito

pessoa1.Nome = "Helo";
pessoa1.Idade = 20;
pessoa1.Apresentar();