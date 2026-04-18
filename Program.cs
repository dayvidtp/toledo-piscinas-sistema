using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Repository;
using toledo_piscinas_sistema.Services;
using toledo_piscinas_sistema.UI;


ClienteRepository clienteRepository = new ClienteRepository();
List<Cliente> clientes = clienteRepository.CarregarClientes();

LimpezaRepository limpezaRepository = new LimpezaRepository();
List<Limpeza> limpezas = limpezaRepository.CarregarLimpezas();

ClienteService gerenciadorClientes = new ClienteService();
LimpezaService gerenciadorLimpezas = new LimpezaService();

MenuService menu = new MenuService();
ConsoleUI consoleUI = new ConsoleUI();

bool continuar = true;

while (continuar)
{
    Console.Clear();
    consoleUI.MostrarMenu();
    continuar = menu.Exibir(clientes, limpezas);
}



