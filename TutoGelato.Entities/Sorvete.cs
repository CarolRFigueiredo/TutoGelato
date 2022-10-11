using System;

namespace TutoGelato.Entities
{
    public class Sorvete
    {
        public Guid Id { get; set; }
        public Marca Marca { get; set; }
        public string Sabor { get; set; }
        public string Cor { get; set; }
    }
}
