using Confeitaria.Api.Enums;
using Confeitaria.Api.ViewModels.Outputs;

namespace Confeitaria.Api.Entities
{
    public class Ingrediente
    {
        protected Ingrediente() { }

        public Ingrediente(int id, string nome, UnidadeMedida unidadeMedida)
        {
            Id = id;
            Nome = nome;
            UnidadeMedida = unidadeMedida;
        }

        public Ingrediente(string nome, UnidadeMedida unidadeMedida)
        {
            Nome = nome;
            UnidadeMedida = unidadeMedida;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public UnidadeMedida UnidadeMedida { get; private set; }

        public void Atualizar(string nome, UnidadeMedida unidadeMedida)
        {
            Nome = nome;
            UnidadeMedida = unidadeMedida;
        }

        public IngredienteOutput ConverterParaIngredienteOutput()
            => new()
            {
                Id = Id,
                Nome = Nome,
                UnidadeMedida = UnidadeMedida,
            };
    }
}
