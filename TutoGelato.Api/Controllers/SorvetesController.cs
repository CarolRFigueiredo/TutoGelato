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
        public readonly IBuscarSorveteUseCase _buscarSorveteUseCase;

        public SorvetesController(ICriarSorveteUseCase criarSorveteUseCase, IBuscarSorveteUseCase buscarSorveteUseCase)
        {
            _criarSorveteUseCase = criarSorveteUseCase;
            _buscarSorveteUseCase = buscarSorveteUseCase;
        }

        [HttpPost]
        public Guid Criar(Sorvete sorvete)
        {
            return _criarSorveteUseCase.Executar(sorvete);
        }

        [HttpGet("{id}")]
        public Sorvete Get(Guid id)
        {
            return _buscarSorveteUseCase.Executar(id);
        }
    }
}
