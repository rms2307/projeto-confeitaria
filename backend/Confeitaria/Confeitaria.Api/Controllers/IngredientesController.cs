using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.ViewModels.Inputs;
using Confeitaria.Api.ViewModels.Outputs;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace Confeitaria.Api.Controllers
{
    [ApiController]
    [Route("ingredientes")]
    public class IngredientesController : ControllerBase
    {
        private readonly IObterTodosIngredienteUseCase _obterTodosIngredienteUseCase;
        private readonly IObterUmIngredienteUseCase _obterUmIngredienteUseCase;
        private readonly ICriarIngredienteUseCase _criarIngredienteUseCase;
        private readonly IAtualizarIngredienteUseCase _atualizarIngredienteUseCase;
        private readonly IRemoverIngredienteUseCase _removerIngredienteUseCase;

        public IngredientesController(
            IObterTodosIngredienteUseCase obterTodosIngredienteUseCase,
            IObterUmIngredienteUseCase obterUmIngredienteUseCase,
            ICriarIngredienteUseCase criarIngredienteUseCase,
            IAtualizarIngredienteUseCase atualizarIngredienteUseCase,
            IRemoverIngredienteUseCase removerIngredienteUseCase)
        {
            _obterTodosIngredienteUseCase = obterTodosIngredienteUseCase;
            _obterUmIngredienteUseCase = obterUmIngredienteUseCase;
            _criarIngredienteUseCase = criarIngredienteUseCase;
            _atualizarIngredienteUseCase = atualizarIngredienteUseCase;
            _removerIngredienteUseCase = removerIngredienteUseCase;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Obtém a lista de todos os ingredientes.")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Lista de ingredientes.", typeof(IEnumerable<IngredienteOutput>))]
        public async Task<IActionResult> ObterTodos()
        {
            IEnumerable<IngredienteOutput> ingredientes = await _obterTodosIngredienteUseCase.ObterTodosAsync();

            return Ok(ingredientes);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtém um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Um ingrediente.", typeof(IngredienteOutput))]
        public async Task<IActionResult> Obter([FromRoute] int id)
        {
            IngredienteOutput ingrediente = await _obterUmIngredienteUseCase.ObterAsync(id);

            return Ok(ingrediente);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cria um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.Created, "Id do ingrediente criado.")]
        public async Task<IActionResult> Criar([FromBody] CriarIngredienteInput input)
        {
            await _criarIngredienteUseCase.CriarAsync(input);

            return Created(string.Empty, input);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atualiza um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Atualizar([FromRoute] int id, AtualizarIngredienteInput input)
        {
            await _atualizarIngredienteUseCase.AtualizarAsync(id, input);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Atualiza um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Remover([FromRoute] int id)
        {
            await _removerIngredienteUseCase.RemoverAsync(id);

            return NoContent();
        }
    }
}
