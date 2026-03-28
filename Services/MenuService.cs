using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Services
{
    class MenuService
    {
        public void Exibir(List<Cliente> clientes, List<Limpeza> limpezas, ClienteService cliente, LimpezaService limpeza)
        {
            while (true)
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

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

                //Validação do ReadLine();
                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Digite um número válido!");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        cliente.CadastrarCliente(clientes);
                        break;
                    case 2:
                        cliente.ListarClientes(clientes);
                        break;
                    case 3:
                        limpeza.RegistrarLimpeza(limpezas, clientes, cliente);
                        break;
                    case 4:
                        limpeza.ListarLimpezas(limpezas);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(1000);
                        return;
                    default:
                        Console.WriteLine("Número Inválido");
                        break;
                }
            }
        }
    }
}
