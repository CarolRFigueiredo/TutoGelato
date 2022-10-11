using System;
using System.Collections.Generic;
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

        public Guid Criar(Sorvete sorvete)
        {
            sorvetes.Add(sorvete);

            return sorvete.Id;
        }
    }
}
