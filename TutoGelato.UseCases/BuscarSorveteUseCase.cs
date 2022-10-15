using System;
using TutoGelato.Borders.Repositories;
using TutoGelato.Borders.UseCases;
using TutoGelato.Entities;

namespace TutoGelato.UseCases
{
    public class BuscarSorveteUseCase : IBuscarSorveteUseCase
    {
        public readonly ISorveteRepository _sorveteRepository;
        public BuscarSorveteUseCase(ISorveteRepository sorveteRepository)
        {
            _sorveteRepository = sorveteRepository;
        }

        public Sorvete Executar(Guid id)
        {
            return _sorveteRepository.BuscarById(id);
        }
    }
}
