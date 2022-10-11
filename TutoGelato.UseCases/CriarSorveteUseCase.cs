using System;
using TutoGelato.Borders.Repositories;
using TutoGelato.Borders.UseCases;
using TutoGelato.Entities;

namespace TutoGelato.UseCases
{
    public class CriarSorveteUseCase : ICriarSorveteUseCase
    {
        public readonly ISorveteRepository _sorveteRepository;
        public CriarSorveteUseCase(ISorveteRepository sorveteRepository)  
        {
            _sorveteRepository = sorveteRepository;
        }

        public Guid Executar(Sorvete sorvete)
        {
            if (sorvete.Sabor != string.Empty && sorvete.Cor != string.Empty)
            {
                sorvete.Id = Guid.NewGuid();

                return _sorveteRepository.Criar(sorvete);
            }
            else 
            {
                return Guid.Empty;
            }
        }
    }
}
