namespace Dominio.Modelos
{
    public class TransacaoModelo
    {
        public Guid Id { get; set; }
        public bool Tipo {  get; set; }
        public Guid CategoriaId { get; set; }
        public string Descricao {  get; set; }
        public DateTime Data { get; set; }
        public float Valor { get; set; }

        // Navigation properties

        public CategoriaModelo Categoria { get; set; }
    }
}
