using System;
using System.Collections.Generic; 
using OpenQA.Selenium; 
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 
using InvoiceCloudTestAutomationProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvoiceCloudTestAutomationProject
{
    [TestClass]
    public class ElementAssertionTest
    {
        private String appURL = "https://the-internet.herokuapp.com/add_remove_elements/"; 

        [TestMethod]
        public void AddElementsToPage()
        {
            IWebDriver driver;       
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(appURL);

            MultipleClicks multipleClicks = new MultipleClicks();
            IWebElement addElementButton = driver.FindElement(By.XPath("//button[contains(text(), 'Add Element')]"));

            multipleClicks.ClickElementButton(10, addElementButton);

            IList<IWebElement> selectElements = driver.FindElements(By.XPath("//button[contains(text(), 'Delete')]"));
            Assert.AreEqual(selectElements.Count, 10);

            driver.Quit(); 

        }
    }
}