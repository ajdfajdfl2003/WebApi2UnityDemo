﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebApi2Unity.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ProductApiIntegrationTestingFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "ProductApi.IntegrationTesting.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProductApiIntegrationTesting", "\tIn order to avoid silly mistakes\r\n\tAs a idiot\r\n\tI want to be told the api is ok " +
                    "nor not.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "ProductApiIntegrationTesting")))
            {
                global::WebApi2Unity.Tests.Features.ProductApiIntegrationTestingFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("功能ProductApiIntegrationTesting，BlocationProducts查詢Get，成功取得資料。")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProductApiIntegrationTesting")]
        public virtual void 功能ProductApiIntegrationTestingBlocationProducts查詢Get成功取得資料()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("功能ProductApiIntegrationTesting，BlocationProducts查詢Get，成功取得資料。", ((string[])(null)));
#line 6
 this.ScenarioSetup(scenarioInfo);
#line 7
  testRunner.Given("建立 http://localhost:33834/api/BProducts 測試物件", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Price"});
            table1.AddRow(new string[] {
                        "2",
                        "Orange",
                        "40"});
            table1.AddRow(new string[] {
                        "3",
                        "Guava",
                        "50"});
#line 8
  testRunner.And("預計 ProductDb02Context 的 Product 資料表應有", ((string)(null)), table1, "And ");
#line 12
  testRunner.When("開始查詢", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
  testRunner.Then("查詢Get結果應為Ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Price"});
            table2.AddRow(new string[] {
                        "2",
                        "Orange",
                        "40.0000"});
            table2.AddRow(new string[] {
                        "3",
                        "Guava",
                        "50.0000"});
#line 14
  testRunner.And("結果應為", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("功能ProductApiIntegrationTesting，AlocationProducts查詢Get，成功取得資料。")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ProductApiIntegrationTesting")]
        public virtual void 功能ProductApiIntegrationTestingAlocationProducts查詢Get成功取得資料()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("功能ProductApiIntegrationTesting，AlocationProducts查詢Get，成功取得資料。", ((string[])(null)));
#line 19
 this.ScenarioSetup(scenarioInfo);
#line 20
  testRunner.Given("建立 http://localhost:33834/api/AProducts 測試物件", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Price"});
            table3.AddRow(new string[] {
                        "1",
                        "Apple",
                        "30"});
            table3.AddRow(new string[] {
                        "3",
                        "Guava",
                        "50"});
#line 21
  testRunner.And("預計 ProductDb01Context 的 Product 資料表應有", ((string)(null)), table3, "And ");
#line 25
  testRunner.When("開始查詢", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
  testRunner.Then("查詢Get結果應為Ok", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Price"});
            table4.AddRow(new string[] {
                        "1",
                        "Apple",
                        "30.0000"});
            table4.AddRow(new string[] {
                        "3",
                        "Guava",
                        "50.0000"});
#line 27
  testRunner.And("結果應為", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
