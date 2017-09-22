using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WebApi2Unity.Models;

namespace WebApi2Unity.Utility
{
    public class ProductRepo
    {
        private readonly string _dbConnectionString;

        public ProductRepo(string dbContext)
        {
            this._dbConnectionString = ConfigurationManager.ConnectionStrings[dbContext].ConnectionString;
        }

        public IEnumerable<Product> GetAll()
        {
            using (var cn = new SqlConnection(this._dbConnectionString))
            {
                var result = cn.Query<Product>("SELECT * FROM dbo.Products");
                return result;
            }
        }
    }
}