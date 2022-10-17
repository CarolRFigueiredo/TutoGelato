using System;
using TutoGelato.Entities;

namespace TutoGelato.Borders.Repositories
{
    public interface IPoteRepository
    {
        public Guid Criar(Pote pote);
    }
}
