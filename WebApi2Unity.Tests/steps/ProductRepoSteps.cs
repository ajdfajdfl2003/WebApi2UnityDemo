using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebApi2Unity.Tests.ModelInTest;
using WebApi2Unity.Utility;
using Product = WebApi2Unity.Models.Product;

namespace WebApi2Unity.Tests.steps
{
    [Binding]
    [Scope(Feature = "ProductRepo")]
    public class ProductRepoSteps
    {
        [BeforeScenario]
        public void Bs()
        {
            using (var db = new ProductDb01Context())
            {
                db.Database.ExecuteSqlCommand("Delete From dbo.Products");
            }
        }

        [Given(@"連接Db的名字 (.*)")]
        public void Given連接db的名字ProductDb(string dbContext)
        {
            ScenarioContext.Current.Set(dbContext, "dbContext");
        }

        [Given(@"預計 Product 資料表應有")]
        public void Given預計Product資料表應有(Table table)
        {
            var products = table.CreateSet<ModelInTest.Products>();
            using (var db = new ProductDb01Context())
            {
                db.Products.AddRange(products);
                db.SaveChanges();
            }
        }

        [When(@"呼叫GetAll")]
        public void When呼叫GetAll()
        {
            var dbContext = ScenarioContext.Current.Get<string>("dbContext");
            var target = new ProductRepo(dbContext);
            var actual = target.GetAll();
            ScenarioContext.Current.Set(actual, "actual");
        }

        [Then(@"結果應為")]
        public void Then結果應為(Table table)
        {
            var actual = ScenarioContext.Current.Get<IEnumerable<Product>>("actual");
            table.CompareToSet(actual);
        }
    }
}