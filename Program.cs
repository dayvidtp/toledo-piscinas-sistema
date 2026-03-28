using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Services;

List<Cliente> clientes = new List<Cliente>();
List<Limpeza> limpezas = new List<Limpeza>();

ClienteService gerenciadorClientes = new ClienteService();
Limpeza gerenciadorLimpezas = new Limpeza(DateTime.Now, "", null);

MenuService menu = new MenuService();
menu.Exibir(clientes, limpezas, gerenciadorClientes, gerenciadorLimpezas);

class Limpeza
{
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public Cliente Cliente { get; set; }

    public Limpeza(DateTime data, string descricao, Cliente cliente)
    {
        Data = data;
        Descricao = descricao;
        Cliente = cliente;
    }

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

        Limpeza limpeza = new Limpeza(DateTime.Now, descricao, clienteSelecionado);
        limpezas.Add(limpeza);

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

