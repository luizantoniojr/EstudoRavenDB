using EstudoRavenDB.Domain.Interfaces;
using EstudoRavenDB.Domain.Services;
using EstudoRavenDB.Infra.Data.RaivenDB.Repositories;
using Ninject.Modules;

namespace EstudoRavenDB.Infra.Data.IoC {
    public class NinjectModulo : NinjectModule {
        public override void Load() {
            Bind<IModeloService>().To<ModeloService>();
            Bind<IMarcaService>().To<MarcaService>();
            Bind<IImpressoraService>().To<ImpressoraService>();
            Bind<IModeloRepository>().To<ModeloRepository>();
            Bind<IMarcaRepository>().To<MarcaRepository>();
            Bind<IImpressoraRepository>().To<ImpressoraRepository>();
        }
    }
}
