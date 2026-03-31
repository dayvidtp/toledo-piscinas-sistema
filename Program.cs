using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Services;
using toledo_piscinas_sistema.UI;

List<Cliente> clientes = new List<Cliente>();
List<Limpeza> limpezas = new List<Limpeza>();

ClienteService gerenciadorClientes = new ClienteService();
LimpezaService gerenciadorLimpezas = new LimpezaService();

MenuService menu = new MenuService();
ConsoleUI consoleUI = new ConsoleUI();

while (true)
{
    consoleUI.consoleMenu();
    menu.Exibir(clientes, limpezas, gerenciadorClientes, gerenciadorLimpezas);
}

