using EstudoRavenDB.Domain.Entities;
using EstudoRavenDB.Domain.Interfaces;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EstudoRavenDB.API.Controllers {
    public class MarcaController : ApiController
    {
        readonly IMarcaService _marcaService;
        public MarcaController(IMarcaService marcaService) {
            _marcaService = marcaService;
        }

        [Route("marcas")]
        public HttpResponseMessage Post(Marca marca) {
            if (marca == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            try {
                return Request.CreateResponse(HttpStatusCode.Created, _marcaService.Inserir(marca));
            } catch (Exception e) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Route("marcas/id/{id}")]
        public HttpResponseMessage Get(Guid id) {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            try {
                return Request.CreateResponse(HttpStatusCode.Created, _marcaService.Buscar(id));
            } catch (Exception e) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Route("marcas/nome/{nome}")]
        public HttpResponseMessage Get(string nome) {
            if (nome == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            try {
                var marcas = _marcaService.Buscar(nome);
                return Request.CreateResponse(HttpStatusCode.Created, marcas);
            } catch (Exception e) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
