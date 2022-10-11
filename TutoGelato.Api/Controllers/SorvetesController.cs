using Microsoft.AspNetCore.Mvc;
using TutoGelato.Borders.UseCases;
using TutoGelato.Entities;

namespace TutoGelato.Api.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class SorvetesController : ControllerBase
    {
        public readonly ICriarSorveteUseCase _criarSorveteUseCase;

        public SorvetesController(ICriarSorveteUseCase criarSorveteUseCase)
        {
            _criarSorveteUseCase = criarSorveteUseCase;
        }

        [HttpPost]
        public Guid Criar(Sorvete sorvete)
        {
            return _criarSorveteUseCase.Executar(sorvete);
        }
    }
}
