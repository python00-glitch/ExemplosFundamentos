using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    /// <summary>
    /// Classe para descrever uma pessoa física para o banco de dados.
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Email { get; set; }
        public string? Endereço { get; set; }

        /// <summary>
        /// Método para a pessoa se apresentar com nome, idade e endereço
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos. Meu e-mail é {Email}");
            Console.WriteLine($"Eu moro em {Endereço}");
        }
    }
}