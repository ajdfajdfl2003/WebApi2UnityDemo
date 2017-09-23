using Microsoft.Practices.Unity;
using System.Web.Http;
using WebApi2Unity.Interfaces;

namespace WebApi2Unity.Controllers
{
    public class AProductsController : ApiController
    {
        private IProductRepo repo;

        public AProductsController([Dependency("AProducts")] IProductRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = repo.GetAll();
            return Ok(result);
        }
    }
}