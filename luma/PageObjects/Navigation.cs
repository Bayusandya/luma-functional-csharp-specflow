using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace luma.PageObjects
{
    class Navigation
    {
        private const string BaseUrl = "https://magento.softwaretestingboard.com/";
        private const string menSection = "https://magento.softwaretestingboard.com/men.html";
        private const string menJackets = "https://magento.softwaretestingboard.com/men/tops-men/jackets-men.html";
        private const string myAccount = "https://magento.softwaretestingboard.com/customer/account/";
        private readonly IWebDriver _webDriver;
        public const int DefaultWaitInSeconds = 5;

        public Navigation(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Elements
        private IWebElement menMenuBarBtn => _webDriver.FindElement(By.Id("#ui-id-2"));
        private IWebElement menJacketsSideBarBtn=> _webDriver.FindElement(By.Id("body > div:nth-child(5) > main:nth-child(4) > div:nth-child(5) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > ul:nth-child(2) > li:nth-child(2) > a:nth-child(1)"));
        private IWebElement menPantsSideBarBtn=> _webDriver.FindElement(By.CssSelector("//a[contains(text(),'Pants')]"));
        private IWebElement showCartBtn => _webDriver.FindElement(By.CssSelector(".action.showcart"));
        private IWebElement topCartCheckoutBtn => _webDriver.FindElement(By.XPath("//span[normalize-space()='View and Edit Cart']"));
        private IWebElement pantsMenuBtn => _webDriver.FindElement(By.XPath("//a[contains(text(),'Pants')]"));
        private IWebElement placeOrderBtn => _webDriver.FindElement(By.CssSelector("button[title='Place Order']"));

        //Methods
        public void GoToHomePage()
        {
            _webDriver.Navigate().GoToUrl(BaseUrl);
        }
        public void GoToMenSectionPage()
        {
            _webDriver.Navigate().GoToUrl(menSection);
        } 
        public void GoToMenJacketsPage()
        {
            _webDriver.Navigate().GoToUrl(menJackets);
        }
        public void GoToMyAccount()
        {
            _webDriver.Navigate().GoToUrl(myAccount);
        }

        public void GoToMenSection() => menMenuBarBtn.Click();
        public void GoToMenJackets() => menJacketsSideBarBtn.Click();
        public void GoToMenPants() => menPantsSideBarBtn.Click();
        public void clickShowCartBtn() => showCartBtn.Click();
        public void clickTopCartCheckoutBtn() => topCartCheckoutBtn.Click();
        public void clickPantsMenuBtn() => pantsMenuBtn.Click();
        public void clickPlaceOrderBtnn() => placeOrderBtn.Click();
    }
}