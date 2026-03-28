using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Services
{
    class LimpezaService
    {
        public void RegistrarLimpeza(List<Limpeza> limpezas, List<Cliente> clientes, ClienteService cli)
        {
            //Escolha de cliente
            cli.ListarClientes(clientes);
            Console.Write("Escolha o cliente pelo número: ");
            int escolha = int.Parse(Console.ReadLine());

            Cliente clienteSelecionado;

            if (escolha > 0 && escolha <= clientes.Count)
            {
                clienteSelecionado = clientes[escolha - 1];
            }
            else
            {
                Console.WriteLine("Cliente inválido!");
                return;
            }

            //Registrar limpeza
            Console.Write("Descrição da limpeza: ");
            string descricao = Console.ReadLine();

            Limpeza novaLimpeza = new Limpeza(DateTime.Now, descricao, clienteSelecionado);
            limpezas.Add(novaLimpeza);



            Console.WriteLine("Limpeza Ristrada com Sucesso!");
            Thread.Sleep(1000);
        }

        public void ListarLimpezas(List<Limpeza> limpezas)
        {
            foreach (var limpeza in limpezas)
            {
                Console.WriteLine($"Cliente: {limpeza.Cliente.Nome} | Data: {limpeza.Data:dd/MM/yyyy HH:mm} | {limpeza.Descricao}");
            }
        }
    }
}
