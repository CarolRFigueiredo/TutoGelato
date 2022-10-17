using System.Collections.Generic;
using TutoGelato.Entities;

namespace TutoGelato.Borders.UseCases
{
    public interface IListarSorvetesUseCase
    {
        public List<Sorvete> Executar();
    }
}
