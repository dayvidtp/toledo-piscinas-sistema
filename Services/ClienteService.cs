using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Services
{
    public class ClienteService
    {
        public Cliente CriarCliente(string nome, string telefone)
        {
            return new Cliente(nome, telefone);
        }

        public void AdicionarCliente(List<Cliente> clientes, Cliente novoCliente)
        {
            clientes.Add(novoCliente);
        }
    }
}
