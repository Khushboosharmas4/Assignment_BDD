using System;
using TechTalk.SpecFlow;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_BDD.Helper;
using Assignment_BDD.PageFactory;
using Assignment_BDD.Actions;

namespace Assignment_BDD.StepDefination
{
    [Binding]
    public class GoogleSearchResultSteps
    {
        private GoogleSearchEnginePage googleSearchEnginePage = new GoogleSearchEnginePage();

        [When(@"I provide '(.*)' keyword to search")]
        public void WhenIProvideKeywordToSearch(string keyword)
        {
            new GoogleSearchEngineAction().TriggerSearch(googleSearchEnginePage, keyword);
        }

        [Then(@"I should get (.*)th result")]
        public void ThenIShouldGetThResultUrl(int index)
        {
            Console.WriteLine("The url of fifth result is : " + googleSearchEnginePage.SearchResult[index - 1].Text);
        }

        [Then(@"I should see (.*) links in the first search page")]
        public void ThenIShouldSeeLinksInTheFirstSearchPage(int LinkCount)
        {
            int resultsCount = googleSearchEnginePage.SearchResult.Count;
            Console.WriteLine("Number of search result returned: " + resultsCount);
            Assert.IsTrue(LinkCount == resultsCount);
        }

        [Then(@"I should not see (.*) links in the first search page")]
        public void ThenIShouldNotSeeLinksInTheFirstSearchPage(int LinkCount)
        {
            int resultsCount = googleSearchEnginePage.SearchResult.Count;
            Console.WriteLine("Number of search result returned: " + resultsCount);
            Assert.AreNotEqual(LinkCount, resultsCount);
        }

        [Given(@"I launch GoogleHomePage")]
        public void GivenILaunchGoogleHomePage()
        {
            string url = ConfigurationManager.AppSettings["googleSearchPage"];
            DriverHelper.driver.Navigate().GoToUrl(url);
        }
    }
}
