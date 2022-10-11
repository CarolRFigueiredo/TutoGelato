using System;
using TutoGelato.Entities;

namespace TutoGelato.Borders.Repositories
{
    public interface ISorveteRepository
    {
        public Guid Criar(Sorvete sorvete);
    }
}
