using Microsoft.AspNetCore.Mvc;
using TutoGelato.Borders.UseCases;
using TutoGelato.Entities;

namespace TutoGelato.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PotesController : ControllerBase
    {
        public readonly ICriarPotesUseCase _criarPotesUseCase;

        public PotesController(ICriarPotesUseCase criarPotesUseCase)
        {
            _criarPotesUseCase = criarPotesUseCase;
        }

        [HttpPost]
        public Guid Criar(Pote pote)
        {
            return _criarPotesUseCase.Executar(pote);
        }

    }
}
