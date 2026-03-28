using toledo_piscinas_sistema.Models;
using toledo_piscinas_sistema.Services;

List<Cliente> clientes = new List<Cliente>();
List<Limpeza> limpezas = new List<Limpeza>();

ClienteService gerenciadorClientes = new ClienteService();
LimpezaService gerenciadorLimpezas = new LimpezaService();

MenuService menu = new MenuService();
menu.Exibir(clientes, limpezas, gerenciadorClientes, gerenciadorLimpezas);

