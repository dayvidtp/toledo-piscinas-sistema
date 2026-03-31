using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.UI;

namespace toledo_piscinas_sistema.Services
{
    public class MenuService
    {
        ConsoleUI consoleUI = new ConsoleUI();
        ClienteService clienteService = new ClienteService();

        public void Exibir(List<Cliente> clientes, List<Limpeza> limpezas, ClienteService clienteService, LimpezaService limpezaService)
        {
            //Validação do ReadLine();
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Digite um número válido!");
                Thread.Sleep(1000);
                Console.Clear();
                return;
            }

            switch (opcao)
            {
                case 1:
                    Cliente cliente = consoleUI.ObterDadosCliente();
                    clienteService.AdicionarCliente(clientes, cliente);
                    Console.WriteLine("Cliente Adicionado com Sucesso!");
                    break;
                case 2:
                    consoleUI.MostrarClientes(clientes);
                    break;
                case 3:
                    consoleUI.MostrarClientes(clientes);
                    limpezaService.RegistrarLimpeza(limpezas, clientes);
                    break;
                case 4:
                    limpezaService.ListarLimpezas(limpezas);
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Número Inválido");
                    break;
            }
            Thread.Sleep(1000);
            Console.Clear();

        }
    }
}
