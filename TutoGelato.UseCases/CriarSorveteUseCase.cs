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
                Sorvete sorveteExistente = _sorveteRepository.BuscarByMarcaSaborCor(sorvete.Marca, sorvete.Sabor, sorvete.Cor);

                if(sorveteExistente == null)
                {
                    sorvete.Id = Guid.NewGuid();

                    return _sorveteRepository.Criar(sorvete);
                }

                return sorveteExistente.Id;
                
            }
            else 
            {
                return Guid.Empty;
            }
        }
    }
}
