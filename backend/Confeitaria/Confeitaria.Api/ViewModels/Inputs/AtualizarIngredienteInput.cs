﻿using Confeitaria.Api.Enums;

namespace Confeitaria.Api.ViewModels.Inputs
{
    public class AtualizarIngredienteInput
    {
        public string Nome { get; set; } = string.Empty;
        public UnidadeMedida UnidadeMedida { get; set; }
    }
}