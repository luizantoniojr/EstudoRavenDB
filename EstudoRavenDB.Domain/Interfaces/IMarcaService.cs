using EstudoRavenDB.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EstudoRavenDB.Domain.Interfaces {
    public interface IMarcaService {
        Marca Inserir(Marca marca);
        Marca Buscar(Guid id);
        IEnumerable<Marca> Buscar(string nome);
    }
}
