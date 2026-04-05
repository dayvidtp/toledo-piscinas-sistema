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

            //Mostra o caminho a percorrer de forma segura, garantida.
            string caminho = Path.Combine(Directory.GetCurrentDirectory(), "clientes.json");

            try
            {
                //Salva o arquivo JSON no caminho especificado.
                File.WriteAllText(caminho, json);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar clientes: {ex.Message}");

            }
        }

        public void CarregarClientes(List<Cliente> clientes)
        {
            string caminho = Path.Combine(Directory.GetCurrentDirectory(), "clientes.json");
            if (File.Exists(caminho))
            {
                string json = File.ReadAllText(caminho);
                var clientesCarregados = JsonSerializer.Deserialize<List<Cliente>>(json);
                if (clientesCarregados != null)
                {
                    clientes.AddRange(clientesCarregados);
                }
            }
        }

    }
}
