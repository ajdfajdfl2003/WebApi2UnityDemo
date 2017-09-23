using System.Collections.Generic;
using WebApi2Unity.Models;

namespace WebApi2Unity.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
    }
}