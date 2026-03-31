using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Services
{
    public class LimpezaService
    {
        public Limpeza CriarLimpeza(DateTime data, string descricao, Cliente cliente)
        {
            return new Limpeza(data, descricao, cliente);
        }

        public void RegistrarLimpeza(List<Limpeza> limpezas, List<Cliente> clientes, Limpeza novaLimpeza)
        {
            limpezas.Add(novaLimpeza);
        }
    }
}
