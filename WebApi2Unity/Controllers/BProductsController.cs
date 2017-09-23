using System.Web.Http;
using WebApi2Unity.Interfaces;

namespace WebApi2Unity.Controllers
{
    public class BProductsController : ApiController
    {
        private IProductRepo repo;

        public BProductsController(IProductRepo repo)
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