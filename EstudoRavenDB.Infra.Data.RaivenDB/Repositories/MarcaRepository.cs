using EstudoRavenDB.Domain.Entities;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Indexes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace EstudoRavenDB.Infra.Data.RaivenDB.Repositories {
    public class MarcaRepository : AbstractTransformerCreationTask<Marca> , IMarcaRepository {

        public Marca Inserir(Marca marca) {

            using (IDocumentStore store = new DocumentStore {
                Url = ConfigurationManager.AppSettings["UrlRavenDB"], 
                DefaultDatabase = ConfigurationManager.AppSettings["DataBase"]  
            }) {
                store.Initialize();
                using (IDocumentSession session = store.OpenSession()) 
                {
                    session.Store(marca); 
                    Guid marcaId = marca.Id;                 
                    session.SaveChanges(); 
                    marca = session.Load<Marca>(marcaId);
                }
            }
            return marca;
        }

        public Marca Buscar(Guid id) {

            using (IDocumentStore store = new DocumentStore {
                Url = ConfigurationManager.AppSettings["UrlRavenDB"],
                DefaultDatabase = ConfigurationManager.AppSettings["DataBase"]
            }) {
                store.Initialize();
                using (IDocumentSession session = store.OpenSession()) {
                    return session.Load<Marca>(id);
                }
            }
        }

        public IEnumerable<Marca> Buscar(string nome) {

            using (IDocumentStore store = new DocumentStore {
                Url = ConfigurationManager.AppSettings["UrlRavenDB"],
                DefaultDatabase = ConfigurationManager.AppSettings["DataBase"]
            }) {
                store.Initialize();
                using (IDocumentSession session = store.OpenSession()) {
                    return session.Query<Marca>().Where(m => m.Nome == nome).ToList();
                }
            }
        }
    }
}
