using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Repository;
using toledo_piscinas_sistema.Services;
using toledo_piscinas_sistema.UI;


ClienteRepository clienteRepository = new ClienteRepository();
List<Cliente> clientes = clienteRepository.CarregarClientes();

List<Limpeza> limpezas = new List<Limpeza>();

ClienteService gerenciadorClientes = new ClienteService();
LimpezaService gerenciadorLimpezas = new LimpezaService();

MenuService menu = new MenuService();
ConsoleUI consoleUI = new ConsoleUI();

while (true)
{
    Console.Clear();
    consoleUI.MostrarMenu();
    menu.Exibir(clientes, limpezas);
}

