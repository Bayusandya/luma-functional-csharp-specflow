using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace luma.PageObjects
{
    class MyAccountPage
    {
        private readonly IWebDriver _webDriver;
        public MyAccountPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Elements
        private IWebElement myOrderBtn => _webDriver.FindElement(By.XPath("//a[normalize-space()='My Orders']"));

        //Methods
        public void clickMyOrderPage() => myOrderBtn.Click();
    }
}
