using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using toledo_piscinas_sistema.Models;

namespace toledo_piscinas_sistema.Repository
{
    public class LimpezaRepository
    {
        public void SalvarLimpezas(List<Limpeza> limpezas)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            //Serializa a lista de limpezas para o formato JSON.
            string json = JsonSerializer.Serialize(limpezas, options);

            //Mostra o caminho a percorrer de forma segura, garantida.
            string caminho = Path.Combine(Directory.GetCurrentDirectory(), "limpezas.json");
            try
            {
                //Salva o arquivo JSON no caminho especificado.
                File.WriteAllText(caminho, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar limpezas: {ex.Message}");
            }
        }

        public List<Limpeza> CarregarLimpezas()
        {
            //Mostra o caminho a percorrer de forma segura, garantida.
            string caminho = Path.Combine(Directory.GetCurrentDirectory(), "limpezas.json");

            //Verifica se o arquivo existe antes de tentar ler. Se não existir, retorna uma lista vazia.
            if (!File.Exists(caminho))
            {
                return new List<Limpeza>();
            }

            //Lê o conteúdo do arquivo JSON.
            string json = File.ReadAllText(caminho);

            //Desserializa o JSON para uma lista de limpezas.
            var limpezasCarregadas = JsonSerializer.Deserialize<List<Limpeza>>(json);
            return limpezasCarregadas ?? new List<Limpeza>();
        }
    }
}
