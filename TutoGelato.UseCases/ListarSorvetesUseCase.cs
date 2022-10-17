using System.Collections.Generic;
using TutoGelato.Borders.Repositories;
using TutoGelato.Borders.UseCases;
using TutoGelato.Entities;

namespace TutoGelato.UseCases
{
    public class ListarSorvetesUseCase : IListarSorvetesUseCase
    {
        public readonly ISorveteRepository _sorveteRepository;
        public ListarSorvetesUseCase(ISorveteRepository sorveteRepository)
        {
            _sorveteRepository = sorveteRepository;

        }
        public List<Sorvete> Executar()
        {
            return _sorveteRepository.Listar();
        }
    }
}
