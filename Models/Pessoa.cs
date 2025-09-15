using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetHelo.Models
{
    // Convenção: Nome de classe, propriedade e método -> Pascal Case (sem espaços, e primeira letra maiúscula)
    // o nome do arquivo físico deve ser o mesmo nome da classe
    // não pode abreviações, para ser o mais claro possível, ex: NomeRepLegalPessoaFis
    // o certo seria: NomeRepresentanteLegalDaPessoaFisica (mesmo que seja grande)
    // pra caso outra pessoa for fazer manutenção no seu código, ela conseguir entender
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