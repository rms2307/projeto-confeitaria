using Confeitaria.Api.Entities;
using Confeitaria.Api.Enums;

namespace Confeitaria.Api.ViewModels.Inputs
{
    public record CriarIngredienteInput
    {
        public string Nome { get; set; } = string.Empty;
        public UnidadeMedida UnidadeMedida { get; set; }

        public Ingrediente ConverterParaIngredienteEntity()
            => new(Nome, UnidadeMedida);
    }
}
