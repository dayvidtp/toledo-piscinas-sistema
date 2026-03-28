List<Cliente> clientes = new List<Cliente>();
List<Limpeza> limpezas = new List<Limpeza>();


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
            Cliente.CadastrarCliente(clientes);
            break;
        case 2:
            Cliente.ListarClientes(clientes);
            break;
        case 3:
            Limpeza.RegistrarLimpeza(limpezas, clientes);
            break;
        case 4:
            Limpeza.ListarLimpezas(limpezas);
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
class Cliente
{
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public Cliente(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }
    public static void CadastrarCliente(List<Cliente> clientes)
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o Telefone: ");
        string telefone = (Console.ReadLine());

        clientes.Add(new Cliente(nome, telefone));

        Console.WriteLine("Cliente Cadastrado");
    }

    public static void ListarClientes(List<Cliente> clientes)
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

    public static void RegistrarLimpeza(List<Limpeza> limpezas, List<Cliente> clientes)
    {
        //Escolha de cliente
        Cliente.ListarClientes(clientes);
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

    public static void ListarLimpezas(List<Limpeza> limpezas)
    {
        foreach (var limpeza in limpezas)
        {
            Console.WriteLine($"Cliente: {limpeza.Cliente.Nome} | Data: {limpeza.Data:dd/MM/yyyy HH:mm} | {limpeza.Descricao}");
        }
    }
}

