using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Services
{
    class ClienteService
    {
        public void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Telefone: ");
            string telefone = (Console.ReadLine());

            Cliente cliente1 = new Cliente(nome, telefone);

            clientes.Add(cliente1);

            Console.WriteLine("Cliente Cadastrado");
        }

        public void ListarClientes(List<Cliente> clientes)
        {
            int number = 0;
            foreach (var cliente in clientes)
            {
                number++;
                Console.WriteLine($"{number} - Nome: " +
                    $"{cliente.Nome} | Telefone: {cliente.Telefone}");
            }
        }
    }
}
