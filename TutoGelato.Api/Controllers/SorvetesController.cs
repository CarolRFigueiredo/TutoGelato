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
        public readonly IListarSorvetesUseCase _listarSorvetesUseCase;

        public SorvetesController(ICriarSorveteUseCase criarSorveteUseCase, IBuscarSorveteUseCase buscarSorveteUseCase, IListarSorvetesUseCase listarSorvetesUseCase)
        {
            _criarSorveteUseCase = criarSorveteUseCase;
            _buscarSorveteUseCase = buscarSorveteUseCase;
            _listarSorvetesUseCase = listarSorvetesUseCase;
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

        [HttpGet]
        public List<Sorvete> Listar()
        {
            return _listarSorvetesUseCase.Executar();
        }
            
    }
}
