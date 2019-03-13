using Assignment_BDD.Helper;
using Assignment_BDD.PageFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_BDD.Actions
{
    public class GoogleSearchEngineAction
    {
        public void TriggerSearch(GoogleSearchEnginePage googlePage, string Keyword)
        {
            googlePage.SearchTextBox.SendKeys(Keyword);
            googlePage.SearchTextBox.Submit();
        }
    }
}
