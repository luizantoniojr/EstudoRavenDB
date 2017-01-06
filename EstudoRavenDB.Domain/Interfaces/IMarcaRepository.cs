using EstudoRavenDB.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EstudoRavenDB.Infra.Data.RaivenDB.Repositories {
    public interface IMarcaRepository {
        Marca Inserir(Marca marca);
        Marca Buscar(Guid id);
        IEnumerable<Marca> Buscar(string nome);
    }
}