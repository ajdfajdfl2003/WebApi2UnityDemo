using System.Web.Http;
using WebApi2Unity.Interfaces;

namespace WebApi2Unity.Controllers
{
    public class AProductsController : ApiController
    {
        private IProductRepo repo;

        public AProductsController(IProductRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = repo.Get();
            return Ok(result);
        }
    }
}