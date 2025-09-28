# 🌸 Aprendendo C#

Repositório criado para documentar meus estudos de **C#** através do curso da [DIO](https://www.dio.me/).  
Aqui compartilho minhas anotações, exemplos práticos e dicas que vou aprendendo no caminho.

---

## 📚 Conteúdo de Estudo

### 1. Fundamentos do .NET
- História, evolução e usos do .NET  
- Diferenças entre **.NET Framework (legado)** e **.NET Core/5+**  
- Funcionamento do compilador e diferença entre linguagens compiladas e interpretadas  

---

### 2. Ambiente de Desenvolvimento
- Instalação do **.NET SDK** e configuração no **VS Code**  
- IDEs mais usadas: Visual Studio, VS Code e Rider  

💡 **Dica:** VS Code é leve e flexível, perfeito para começar.  

---

### 3. Sintaxe e Estrutura
- Convenções de código:
  - **PascalCase** → classes, métodos, propriedades  
  - **camelCase** → variáveis  
- Estrutura básica de um programa:
```csharp
using System;

Console.WriteLine("Hello, World!");
```

---

### 4. Tipos de Dados
- **Primitivos**: `string`, `char`, `bool`, `int`, `double`, `decimal`  
- **Exemplo prático**:
```csharp
string apresentacao = "Olá, seja bem-vindo!";
int quantidade = 10;
double altura = 1.60;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Altura: {altura:0.00}");
Console.WriteLine($"Preço: {preco}");
Console.WriteLine($"Condição: {condicao}");
```

---

### 5. Conversões
- **String → Int**
```csharp
int a = int.Parse("5");
int b = Convert.ToInt32("5");
```
- **TryParse (seguro)**
```csharp
if (int.TryParse("15", out int numero))
{
    Console.WriteLine(numero);
}

```
- **Int → String**
```csharp
int inteiro = 5;
string texto = inteiro.ToString();
```

---

### 6. Operadores e Condições
```csharp
int quantidade1 = 10;
int quantidade2 = 4;
bool condicao = quantidade1 >= quantidade2; // true
```

💡 **Switch com vogais**
```csharp
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É vogal!");
        break;
    default:
        Console.WriteLine("Não é vogal.");
        break;
}
```

---

### 7. Estruturas de Controle
- **for**
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```
- **while**
```csharp
int j = 0;
while (j < 5)
{
    Console.WriteLine(j);
    j++;
}
```
- **foreach**
```csharp
string[] nomes = { "Ana", "Bia", "Carla" };
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
```

---

### 8. Arrays e Listas
📌 **Array** → tamanho fixo  
📌 **List** → tamanho dinâmico  

| Array | Lista |
|-------|-------|
| Precisa definir o tamanho | Cresce automaticamente |
| Mais performático | Mais flexível |
| `int[] numeros = new int[3];` | `List<string> lista = new List<string>();` |

💡 **Exemplo Array**
```csharp
int[] arrayInteiros = { 72, 64, 50 };
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);
}

```

💡 **Exemplo Lista**
```csharp
List<string> lista = new List<string>();
lista.Add("SP");
lista.Add("BA");
lista.Add("MG");
lista.Add("RJ");

Console.WriteLine($"Itens: {lista.Count} - Capacidade: {lista.Capacity}");

lista.Remove("MG");

foreach (string item in lista)
{
    Console.WriteLine(item);
}

```

---

### 9. Classes e Objetos

#### Pessoa.cs
```csharp
using System;

namespace dotnetHelo.Common.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}
```

**Exemplo de uso:**
```csharp
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Helo";
pessoa1.Idade = 20;
pessoa1.Apresentar();
```

---

#### Calculadora.cs
```csharp
using System;

namespace dotnetHelo.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double numero)
        {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"Raíz quadrada de {numero} = {raiz}");
        }
    }
}
```

**Exemplo de uso:**
```csharp
Calculadora calc = new Calculadora();
calc.Somar(10, 5);
calc.Subtrair(10, 5);
calc.Multiplicar(10, 5);
calc.Dividir(10, 5);
calc.Potencia(10, 5);
calc.Seno(45);
calc.Cosseno(45);
calc.Tangente(45);
calc.RaizQuadrada(9);
```

---

### 10. Datas
```csharp
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

DateTime dataFutura = dataAtual.AddDays(5);
Console.WriteLine(dataFutura);
```

---

## 🚀 Objetivo
Manter um registro limpo e organizado da minha evolução em **C#**, para consulta futura e como base para novos projetos.

---

## 🔗 Links Úteis
- [Documentação oficial do .NET](https://learn.microsoft.com/pt-br/dotnet/)  
- [Download do .NET SDK](https://dotnet.microsoft.com/en-us/download)  
- [Visual Studio Code](https://code.visualstudio.com/)  

---

✨ Desenvolvido por **Heloisa Giacometti**  
Repositório: [Learning-C-Sharp](https://github.com/heloziza/Learning-C-Sharp)
