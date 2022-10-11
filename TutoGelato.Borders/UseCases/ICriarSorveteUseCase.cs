using System;
using TutoGelato.Entities;

namespace TutoGelato.Borders.UseCases
{
    public interface ICriarSorveteUseCase
    {
        public Guid Executar(Sorvete sorvete);
    }
}
