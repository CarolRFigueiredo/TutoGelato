using System;
using System.Collections.Generic;
using System.Linq;
using TutoGelato.Borders.Repositories;
using TutoGelato.Entities;

namespace TutoGelato.Repositories
{
    public class SorveteRepository : ISorveteRepository
    {
        public List<Sorvete> sorvetes;

        public SorveteRepository() 
        {
            sorvetes = new List<Sorvete>();
        }

        public Sorvete BuscarById(Guid id)
        {
            return sorvetes.FirstOrDefault(s => s.Id == id);
        }

        public Sorvete BuscarByMarcaSaborCor(Marca marca, string sabor, string cor)
        {
            return sorvetes.FirstOrDefault(s => s.Cor == cor && s.Sabor == sabor && s.Marca == marca);
        }

        public Guid Criar(Sorvete sorvete)
        {
            sorvetes.Add(sorvete);

            return sorvete.Id;
        }
    }
}
