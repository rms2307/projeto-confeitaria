using Confeitaria.Api.Enums;

namespace Confeitaria.Api.Entities
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public UnidadeMedida UnidadeMedida { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal PrecoMedio { get; set; }
    }
}
