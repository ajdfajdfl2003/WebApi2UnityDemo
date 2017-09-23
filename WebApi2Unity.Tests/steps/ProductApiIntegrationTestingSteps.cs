using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebApi2Unity.Models;
using WebApi2Unity.Tests.ModelInTest;

namespace WebApi2Unity.Tests.steps
{
    [Binding]
    public class ProductApiIntegrationTestingSteps
    {
        [BeforeScenario]
        public void Bs()
        {
            using (var db = new ProductDb01Context())
            {
                db.Database.ExecuteSqlCommand("Delete From dbo.Products");
            }
            using (var db = new ProductDb02Context())
            {
                db.Database.ExecuteSqlCommand("Delete From dbo.Products");
            }
        }

        [AfterScenario]
        public void As()
        {
            using (var db = new ProductDb01Context())
            {
                db.Database.ExecuteSqlCommand("Delete From dbo.Products");
            }
            using (var db = new ProductDb02Context())
            {
                db.Database.ExecuteSqlCommand("Delete From dbo.Products");
            }
        }

        [Given(@"建立 (.*) 測試物件")]
        public void Given建立測試物件(string webUri)
        {
            ScenarioContext.Current.Set(webUri, "webUri");
        }

        [Given(@"預計 ProductDb02Context 的 Product 資料表應有")]
        public void Given預計ProductDb02Context的Product資料表應有(Table table)
        {
            var products = table.CreateSet<ModelInTest.Products>();
            using (var db = new ProductDb02Context())
            {
                db.Products.AddRange(products);
                db.SaveChanges();
            }
        }

        [Given(@"預計 ProductDb01Context 的 Product 資料表應有")]
        public void Given預計ProductDb01Context的Product資料表應有(Table table)
        {
            var products = table.CreateSet<ModelInTest.Products>();
            using (var db = new ProductDb01Context())
            {
                db.Products.AddRange(products);
                db.SaveChanges();
            }
        }

        [When(@"開始查詢")]
        public void When開始查詢()
        {
            var uri = ScenarioContext.Current.Get<string>("webUri");
            var httpRequestMessaget = new HttpRequestMessage(HttpMethod.Get, uri);

            using (var client = new HttpClient())
            {
                var actual = client.SendAsync(httpRequestMessaget);
                ScenarioContext.Current.Set(actual.Result, "actual");
            }
        }

        [Then(@"查詢Get結果應為Ok")]
        public void Then查詢Get結果應為Ok()
        {
            var actual = ScenarioContext.Current.Get<HttpResponseMessage>("actual");
            Assert.AreEqual(HttpStatusCode.OK, actual.StatusCode);
        }

        [Then(@"結果應為")]
        public void Then結果應為(Table table)
        {
            var actual = ScenarioContext.Current.Get<HttpResponseMessage>("actual");
            var responseContent = actual.Content.ReadAsStringAsync().Result;

            var expected = table.CreateSet<Product>();
            var expectedJson = JsonConvert.SerializeObject(expected);
            Assert.AreEqual(expectedJson, responseContent);
        }
    }
}