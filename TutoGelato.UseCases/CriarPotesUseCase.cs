using System;
using TutoGelato.Borders.Repositories;
using TutoGelato.Borders.UseCases;
using TutoGelato.Entities;

namespace TutoGelato.UseCases
{
    public class CriarPotesUseCase : ICriarPotesUseCase
    {
        public readonly IPoteRepository _poteRepository;
        public readonly ISorveteRepository _sorveteRepository;

        public CriarPotesUseCase(IPoteRepository poteRepository, ISorveteRepository sorveteRepository)
        {
            _poteRepository = poteRepository;
            _sorveteRepository = sorveteRepository;

        }

        public Guid Executar(Pote pote)
        {
            Sorvete sorvete = _sorveteRepository.BuscarById(pote.Sorvete.Id);

            if(sorvete != null)
            {

            }
            else
            {
                return Guid.Empty;
            }

        }
    }
}
