using Assignment_BDD.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_BDD.PageFactory
{
    public class GoogleSearchEnginePage
    {
        public IWebElement SearchTextBox 
        { 
            get
            {
                return DriverHelper.driver.FindElement(By.XPath("//input[@name='q']"));
            }
        }

        public IList<IWebElement> SearchResult
        {
            get
            {
                return DriverHelper.driver.FindElements(By.XPath(".//div[@class='rc']/div[@class='r']/a")).Where(element => element.Displayed).ToList();
            }
        }

        public IWebElement SearchButton
        {
            get
            {
                return DriverHelper.driver.FindElement(By.Name("btnK"));
            }
        }
    }
}
