using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Services
{
    public class LimpezaService
    {
        public Limpeza CriarLimpeza(DateTime data, string descricao, Cliente cliente)
        {
            return new Limpeza(data, descricao, cliente);
        }

        public void RegistrarLimpeza(List<Limpeza> limpezas, Limpeza novaLimpeza)
        {
            limpezas.Add(novaLimpeza);
        }

        public List<Limpeza> ObterLimpezasPorCliente(List<Limpeza> limpezas, Cliente cliente)
        {
            return limpezas.Where(l => l.Cliente == cliente).ToList();
        }

        public void DeletarLimpezasPorCliente(List<Limpeza> limpezas, List<Limpeza> dadosLimpezaDoCliente)
            {
            foreach (var limpeza in dadosLimpezaDoCliente)
            {
                limpezas.Remove(limpeza);
            }
        }
    }
}
