using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPratico
{
    public class Cliente
    {
        public string? Nome;
        public int Idade;
        public decimal Renda;

        public Cliente(string? nome, int idade, decimal renda)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Renda = renda;
        }

        public Cliente() { }
    }
}
