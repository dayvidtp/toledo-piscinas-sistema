using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Repository;
using toledo_piscinas_sistema.Services;
using toledo_piscinas_sistema.UI;

List<Cliente> clientes = new List<Cliente>();
List<Limpeza> limpezas = new List<Limpeza>();

ClienteService gerenciadorClientes = new ClienteService();
LimpezaService gerenciadorLimpezas = new LimpezaService();

ClienteRepository clienteRepository = new ClienteRepository();

MenuService menu = new MenuService();
ConsoleUI consoleUI = new ConsoleUI();

clienteRepository.CarregarClientes(clientes);

while (true)
{
    Console.Clear();
    consoleUI.MostrarMenu();
    menu.Exibir(clientes, limpezas);
}

