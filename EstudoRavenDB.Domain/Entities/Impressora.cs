using System;

namespace EstudoRavenDB.Domain.Entities {
    public class Impressora {
        public Guid Id { get; set; }
        public string NumeroSerie { get; set; }
        public Guid ModeloId { get; set; }
        public Modelo Modelo { get; set; }
    }
}
