using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Repository;
using toledo_piscinas_sistema.UI;

namespace toledo_piscinas_sistema.Services
{
    public class MenuService
    {
        ConsoleUI consoleUI = new ConsoleUI();
        ClienteService clienteService = new ClienteService();
        LimpezaService limpezaService = new LimpezaService();
        ClienteRepository clienteRepository = new ClienteRepository(); // Adicionado campo para ClienteRepository

        public void Exibir(List<Cliente> clientes, List<Limpeza> limpezas)
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
                    var dadosCliente = consoleUI.ObterDadosCliente();

                    Cliente cliente = clienteService.CriarCliente(dadosCliente.nome, dadosCliente.telefone);

                    clienteService.AdicionarCliente(clientes, cliente);
                    clienteRepository.SalvarClientes(clientes); // Agora usa o campo corretamente
                    Console.WriteLine("Cliente Adicionado com Sucesso!");
                    break;
                case 2:
                    consoleUI.MostrarClientes(clientes);
                    break;
                case 3:
                    consoleUI.MostrarClientes(clientes);
                    var dadosLimpeza = consoleUI.ObterDadosLimpeza(clientes);

                    Limpeza limpeza = limpezaService.CriarLimpeza(DateTime.Now, dadosLimpeza.descricao, dadosLimpeza.cliente);

                    limpezaService.RegistrarLimpeza(limpezas, limpeza);
                    break;
                case 4:
                    consoleUI.MostrarLimpezas(limpezas);
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
