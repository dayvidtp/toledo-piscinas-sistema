using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Services
{
    public class LimpezaService
    {
        public void RegistrarLimpeza(List<Limpeza> limpezas, List<Cliente> clientes)
        {
            //Escolha de cliente
            Console.Write("Escolha o cliente pelo número: ");

            if (!int.TryParse(Console.ReadLine(), out int escolha))
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um número.");
                return;
            }

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
