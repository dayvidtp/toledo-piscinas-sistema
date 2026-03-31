using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Services;

namespace toledo_piscinas_sistema.UI
{
    public class ConsoleUI
    {
        public void MostrarMenu()
        {

            Console.WriteLine("Bem vindo ao Toledo Piscinas!");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Registrar Limpeza");
            Console.WriteLine("4 - Listar Limpezas");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.Write("Digite o número correspodente à escolha: ");
        }

        public Cliente ObterDadosCliente()
        {
            Console.Write("Digite o nome do Cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Telefone: ");
            string telefone = (Console.ReadLine());

            return new Cliente(nome, telefone);
        }

        public void MostrarClientes(List<Cliente> clientes)
        {
            int i = 1;
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{i} - Nome: {cliente.Nome} | Telefone: {cliente.Telefone}");
                i++;
            }
        }

        public Limpeza ObterDadosLimpeza(List<Cliente> clientes)
        {
            Console.Write("Escolha o cliente pelo número: ");
            int escolha = int.Parse(Console.ReadLine());

            Cliente clienteSelecionado = clientes[escolha - 1];

            if (escolha > 0 && escolha <= clientes.Count)
            {
                clienteSelecionado = clientes[escolha - 1];
            }
            else
            {
                Console.WriteLine("Cliente inválido!");
            }

            Console.Write("Descrição da limpeza: ");
            string descricao = Console.ReadLine();

            return new Limpeza(DateTime.Now, descricao, clienteSelecionado);
        }

        public void MostrarLimpezas(List<Limpeza> limpezas)
        {
            foreach (var limpeza in limpezas)
            {
                if (limpezas.Count == 0)
                {
                    Console.WriteLine("Nenhuma limpeza registrada.");
                    return;
                }
                Console.WriteLine($"Cliente: {limpeza.Cliente.Nome} | Data: {limpeza.Data:dd/MM/yyyy HH:mm} | {limpeza.Descricao}");
            }
        }
    }
}
