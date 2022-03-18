using System;
using OpenQA.Selenium;

namespace InvoiceCloudTestAutomationProject.Helpers
{
    public class MultipleClicks
    {
        public void ClickElementButton(int numberOfClicks, IWebElement addElementButton)
        {
            for (int i = 0; i < numberOfClicks; i++)
            {
                addElementButton.Click();   
            }
        }
    }
}
