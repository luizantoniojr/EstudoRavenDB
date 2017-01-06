using EstudoRavenDB.Domain.Entities;
using EstudoRavenDB.Domain.Interfaces;
using EstudoRavenDB.Infra.Data.RaivenDB.Repositories;
using System;
using System.Collections.Generic;

namespace EstudoRavenDB.Domain.Services {
    public class MarcaService : IMarcaService {
        readonly IMarcaRepository _marcaRepository;
        public MarcaService(IMarcaRepository marcaRepository) {
            _marcaRepository = marcaRepository;
        }
        public Marca Inserir(Marca marca) {
            return _marcaRepository.Inserir(marca);
        }

        public Marca Buscar(Guid id) {
            return _marcaRepository.Buscar(id);
        }

        public IEnumerable<Marca> Buscar(string nome) {
            return _marcaRepository.Buscar(nome);
        }
    }
}
