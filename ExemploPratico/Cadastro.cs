using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPratico
{
    public class Cadastro
    {
        public Cliente Registrar()
        {
            Cliente cliente = new Cliente("Paulo", 35, 3000);
            return cliente;
        }

        public Cliente Registrar(Cliente cliente)
        {
            cliente.Renda = 3500;
            return cliente;
        } 

        public void ExibirDados(Cliente cliente)
        {
            Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
        }

        public void ExibirDados(string texto, Cliente cliente)
        {
            Console.WriteLine($"{texto}");
            Console.WriteLine($"{cliente.Nome} - {cliente.Renda.ToString("c")}");

        }
    }
}
