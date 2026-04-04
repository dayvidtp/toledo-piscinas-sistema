using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Repository
{
    public class ClienteRepository
    {
        public void SalvarClientes(List<Cliente> clientes)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(clientes, options);
            File.WriteAllText("clientes.json", json);
        }
    }
}
