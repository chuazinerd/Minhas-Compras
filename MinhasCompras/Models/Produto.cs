using SQLite;

namespace MinhasCompras.Models
{
    public class Produto
    {
        string _descricao;
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao {
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descricao");
                }
                _descricao = value;
            }
        }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public double Total { get => (Quantidade * Preco) * (1 - Desconto / 100); }
    }
}
