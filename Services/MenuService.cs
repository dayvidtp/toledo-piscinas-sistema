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
        ClienteRepository clienteRepository = new ClienteRepository();
        LimpezaRepository limpezaRepository = new LimpezaRepository();

        public bool Exibir(List<Cliente> clientes, List<Limpeza> limpezas)
        {
            //Validação do ReadLine();
            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Digite um número válido!");
                Thread.Sleep(1000);
                Console.Clear();
                return true;
            }


            switch (opcao)
            {
                case 1: // Adicionar Cliente
                    var dadosCliente = consoleUI.ObterDadosCliente();

                    Cliente cliente = clienteService.CriarCliente(dadosCliente.nome, dadosCliente.telefone);

                    clienteService.AdicionarCliente(clientes, cliente);

                    clienteRepository.SalvarClientes(clientes);
                    Console.WriteLine("Cliente Adicionado com Sucesso!");
                    Thread.Sleep(1500);
                    return true;
                case 2: // Listar Clientes
                    consoleUI.MostrarClientes(clientes);
                    Console.WriteLine("Pressione Enter para Retornar ao Menu...");
                    Console.ReadLine();
                    return true;
                case 3: // Registrar Limpeza
                    consoleUI.MostrarClientes(clientes);

                    var dadosLimpeza = consoleUI.ObterDadosLimpeza(clientes);
                    if (dadosLimpeza.cliente == null)
                    {
                        return true;
                    }

                    Limpeza limpeza = limpezaService.CriarLimpeza(DateTime.Now, dadosLimpeza.descricao, dadosLimpeza.cliente);

                    limpezaService.RegistrarLimpeza(limpezas, limpeza);

                    limpezaRepository.SalvarLimpezas(limpezas);
                    Console.WriteLine("Limpeza Registrada com Sucesso!");
                    Thread.Sleep(1500);
                    return true;
                case 4: // Listar Limpezas
                    consoleUI.MostrarLimpezas(limpezas);
                    Console.WriteLine("Pressione Enter para Retornar ao Menu...");
                    Console.ReadLine();
                    return true;
                case 5: // Deletar Cliente
                    consoleUI.MostrarClientes(clientes);

                    var dadosClienteDeletar = consoleUI.ObterClienteParaDeletar(clientes);
                    if (dadosClienteDeletar.cliente == null)
                    {
                        Console.WriteLine("Cliente não encontrado. Retornando ao menu...");
                        Thread.Sleep(1500);
                        return true;
                    }
                    var dadosLimpezaDoCliente = limpezaService.ObterLimpezasPorCliente(limpezas, dadosClienteDeletar.cliente);

                    clienteService.DeletarCliente(clientes, dadosClienteDeletar.cliente);

                    // Verificar se o cliente possui limpezas associadas e perguntar se deseja deletar as limpezas também
                    string resposta = consoleUI.OpcaoDeDeletarLimpezas();
                    if (resposta.ToUpper() == "S" && dadosLimpezaDoCliente.Count > 0)
                    {
                        limpezaService.DeletarLimpezasPorCliente(limpezas, dadosLimpezaDoCliente);
                    } else if (resposta.ToUpper() == "N" && dadosLimpezaDoCliente.Count > 0)
                    {
                        Console.WriteLine("Limpezas associadas ao cliente não foram deletadas.");
                        Thread.Sleep(1500);
                    } else if (dadosLimpezaDoCliente.Count == 0)
                    {
                        Console.WriteLine("Cliente não possui limpezas associadas.");
                        Thread.Sleep(1500);
                    }

                    clienteRepository.SalvarClientes(clientes);
                    limpezaRepository.SalvarLimpezas(limpezas);

                    Console.WriteLine("Cliente Deletado com Sucesso!");
                    Thread.Sleep(1500);
                    return true;
                case 0:
                    Console.WriteLine("Saindo...");
                    Thread.Sleep(500);
                    return false;
                default:
                    Console.WriteLine("Número Inválido");
                    Thread.Sleep(1000);
                    return true;
            }
        }


    }
}

