using System;
using TutoGelato.Entities;

namespace TutoGelato.Borders.UseCases
{
    public interface ICriarPotesUseCase
    {
        public Guid Executar(Pote pote);
    }
}
