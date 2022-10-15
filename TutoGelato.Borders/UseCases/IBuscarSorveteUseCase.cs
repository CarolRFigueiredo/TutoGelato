using System;
using TutoGelato.Entities;

namespace TutoGelato.Borders.UseCases
{
    public interface IBuscarSorveteUseCase
    {
        public Sorvete Executar(Guid id);
    }
}
