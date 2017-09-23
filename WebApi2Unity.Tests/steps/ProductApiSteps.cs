using NSubstitute;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebApi2Unity.Controllers;
using WebApi2Unity.Interfaces;
using WebApi2Unity.Models;

namespace WebApi2Unity.Tests.steps
{
    [Binding]
    [Scope(Feature = "ProductApi")]
    public class ProductApiSteps
    {
        [Given(@"預計資料表應有")]
        public void Given預計資料表應有(Table table)
        {
            var fakeResult = table.CreateSet<Product>();
            ScenarioContext.Current.Set(fakeResult, "fakeResult");
        }

        [When(@"呼叫查詢AlocationProducts的Get")]
        public void When呼叫查詢AlocationProducts的Get()
        {
            var repo = Substitute.For<IProductRepo>();
            var fakeResult = ScenarioContext.Current.Get<IEnumerable<Product>>("fakeResult");
            repo.GetAll().Returns(fakeResult);
            var target = new AProductsController(repo);

            var actual = target.Get();
            ScenarioContext.Current.Set(actual, "actual");
        }

        [Then(@"查詢Get結果應為Ok，結果應為")]
        public void Then查詢Get結果應為ok結果應為(Table table)
        {
            var actual =
                ScenarioContext.Current.Get<IHttpActionResult>("actual") as
                    OkNegotiatedContentResult<IEnumerable<Product>>;
            table.CompareToSet(actual.Content);
        }
    }
}