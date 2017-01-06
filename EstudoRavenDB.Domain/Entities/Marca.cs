using System;
using System.Collections.Generic;

namespace EstudoRavenDB.Domain.Entities {
    public class Marca {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Modelo> Modelos{ get; set; }
    }
}
