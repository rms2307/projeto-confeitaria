using Confeitaria.Api.Enums;

namespace Confeitaria.Api.ViewModels.Outputs
{
    public record IngredienteOutput
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public UnidadeMedida UnidadeMedida { get; set; }
    }
}
