using System;
using System.Collections.Generic;
using TutoGelato.Entities;

namespace TutoGelato.Borders.Repositories
{
    public interface ISorveteRepository
    {
        public Guid Criar(Sorvete sorvete);
        public Sorvete BuscarById(Guid id);
        public Sorvete BuscarByMarcaSaborCor(Marca marca, string sabor, string cor);
        public List<Sorvete> Listar();
    }
}
