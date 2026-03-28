namespace toledo_piscinas_sistema.Models
{
    class Limpeza
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }

        public Limpeza(DateTime data, string descricao, Cliente cliente)
        {
            Data = data;
            Descricao = descricao;
            Cliente = cliente;
        }
    }
}
