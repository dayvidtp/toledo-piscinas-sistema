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
            Console.WriteLine("5 - Deletar Cliente");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            Console.Write("Digite o número correspodente à escolha: ");
        }

        public (string nome, string telefone) ObterDadosCliente()
        {
            string nome;
            do
            {
                Console.Write("Digite o nome do Cliente: ");
                nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("O nome do cliente não pode ser vazio. Por favor, tente novamente.");
                }

            } while (string.IsNullOrWhiteSpace(nome));

            string telefone;
            do
            {
                Console.Write("Digite o Telefone: ");
                telefone = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(telefone))
                {
                    Console.WriteLine("O telefone do cliente não pode ser vazio. Por favor, tente novamente.");
                }

            } while (string.IsNullOrWhiteSpace(telefone));

            // Remove caracteres não numéricos do telefone
            telefone = new string(telefone.Where(char.IsDigit).ToArray());

            if (telefone.Length < 10)
            {
                Console.WriteLine("O telefone deve conter no mínimo 10 dígitos. Por favor, tente novamente.");
                return ObterDadosCliente(); // Chama o método novamente para obter dados válidos
            }

            return (nome, telefone);
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

        public (Cliente cliente, int escolha) ObterClienteParaDeletar(List<Cliente> clientes)
        {
            Console.Write("Escolha o cliente a ser deletado pelo número: ");
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
            return (clienteSelecionado, escolha);
        }

        public (string descricao, Cliente cliente) ObterDadosLimpeza(List<Cliente> clientes)
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado. Por favor, cadastre um cliente antes de registrar uma limpeza.");
                Thread.Sleep(3000);
                return (null, null); // Corrigido: retorna tupla nula para manter a assinatura correta                
            }

            int escolha;
            Console.Write("Escolha o cliente pelo número: ");
            escolha = int.Parse(Console.ReadLine());

            Cliente clienteSelecionado;

            if (escolha > 0 && escolha <= clientes.Count)
            {
                clienteSelecionado = clientes[escolha - 1];
            }
            else
            {
                Console.WriteLine("Cliente inválido!");
                return ObterDadosLimpeza(clientes); // Chama o método novamente para obter dados válidos
            }

            string descricao;
            do
            {
                Console.Write("Descrição da limpeza: ");
                descricao = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(descricao))
                {
                    Console.WriteLine("A descrição da limpeza não pode ser vazia. Por favor, tente novamente.");
                }
            } while (string.IsNullOrWhiteSpace(descricao));

            return (descricao, clienteSelecionado);
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

        public string OpcaoDeDeletarLimpezas()
        {
            Console.WriteLine("Deseja deletar as limpezas do cliente deletado? (S/N)");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                Console.WriteLine("Limpezas deletadas com Sucesso!");
                Thread.Sleep(1500);
            }
            else if (resposta == "N")
            {
                Console.WriteLine("Limpezas mantidas.");
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("Resposta inválida. Limpezas mantidas por padrão.");
                Thread.Sleep(1500);
            }
            return resposta;
        }
    }
}
