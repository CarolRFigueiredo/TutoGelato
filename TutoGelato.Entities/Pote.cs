using System;

namespace TutoGelato.Entities
{
    public class Pote
    {
        public Guid Id { get; set; }
        public Sorvete  Sorvete { get; set; }
        public decimal Volume { get; set; }
        public decimal Preco { get; set; }
    }
}
