using Confeitaria.Api.Interfaces.UseCases.Ingredientes;
using Confeitaria.Api.ViewModels.Inputs;
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
        private readonly IRemoverTodosIngredienteUseCase _removerIngredienteUseCase;

        public IngredientesController(
            IObterTodosIngredienteUseCase obterTodosIngredienteUseCase,
            IObterUmIngredienteUseCase obterUmIngredienteUseCase,
            ICriarIngredienteUseCase criarIngredienteUseCase,
            IAtualizarIngredienteUseCase atualizarIngredienteUseCase,
            IRemoverTodosIngredienteUseCase removerIngredienteUseCase)
        {
            _obterTodosIngredienteUseCase = obterTodosIngredienteUseCase;
            _obterUmIngredienteUseCase = obterUmIngredienteUseCase;
            _criarIngredienteUseCase = criarIngredienteUseCase;
            _atualizarIngredienteUseCase = atualizarIngredienteUseCase;
            _removerIngredienteUseCase = removerIngredienteUseCase;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Obtém a lista de todos os ingredientes.")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Lista de ingredientes.")]
        public async Task<IActionResult> ObterTodos()
        {


            return Ok();
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtém um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Um ingrediente.")]
        public async Task<IActionResult> Obter([FromRoute] int id)
        {


            return Ok();
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Cria um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.Created, "Id do ingrediente criado.")]
        public async Task<IActionResult> Criar([FromBody] CriarIngredienteInput input)
        {
            int id = await _criarIngredienteUseCase.Criar(input);

            return Created();
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Atualiza um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Atualizar([FromRoute] int id, AtualizarIngredienteInput input)
        {


            return NoContent();
        }



        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Atualiza um ingrediente.")]
        [SwaggerResponse((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Remover([FromRoute] int id)
        {


            return NoContent();
        }
    }
}
