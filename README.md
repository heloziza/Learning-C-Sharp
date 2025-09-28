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
- Principais: `string`, `char`, `bool`, `int`, `decimal`, `double`  
- Uso do `decimal` para valores monetários:
```csharp
decimal preco = 1.99M;
```
- Trabalhando com datas:
```csharp
DateTime dataAtual = DateTime.Now;
DateTime dataAtualMaisCincoDias = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
```

---

### 5. Conversões
- **String → Int**
```csharp
int a = int.Parse("5"); // só se tiver certeza
int b = Convert.ToInt32("5"); // mais seguro
```
- **TryParse (evita erros)**
```csharp
if (int.TryParse("15", out int numero))
    Console.WriteLine(numero);
```
- **Int → String**
```csharp
int inteiro = 5;
string texto = inteiro.ToString();
```

---

### 6. Operadores
- Aritméticos: `+`, `-`, `*`, `/`, `%`  
- Lógicos: `&&`, `||`, `!`  
- Condicionais: `if`, `else`, `switch`

💡 **Exemplo de ordem dos operadores:**
```csharp
int resultado = 4 / 2 + 2; // = 4
```

---

### 7. Estruturas de Controle
- **for**
```csharp
for (int i = 0; i < 5; i++)
    Console.WriteLine(i);
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
    Console.WriteLine(nome);
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
int[] array = { 10, 20, 30 };
for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);
```

💡 **Exemplo Lista**
```csharp
List<string> lista = new List<string>();
lista.Add("SP");
lista.Add("RJ");
lista.Remove("RJ");

foreach (string item in lista)
    Console.WriteLine(item);
```

---

### 9. Boas Práticas
- Usar nomes descritivos para variáveis e métodos  
- Evitar abreviações  
- Comentar o necessário (nem de mais, nem de menos)  
- Preferir `TryParse` ao `Parse` quando não tiver certeza do valor  

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
