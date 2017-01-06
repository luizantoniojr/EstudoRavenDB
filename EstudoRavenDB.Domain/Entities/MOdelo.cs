using System;
using System.Collections.Generic;

namespace EstudoRavenDB.Domain.Entities {
    public class Modelo {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid MarcaId { get; set; }
        public Marca Marca { get; set; }
        public IEnumerable<Impressora> Impressoras { get; set; }
    }
}
