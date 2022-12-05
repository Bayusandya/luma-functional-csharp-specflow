using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace luma.PageObjects
{
    class Orders
    {
        private readonly IWebDriver _webDriver;
        public Orders(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Product 1
        private IWebElement proteusDetailBtn => _webDriver.FindElement(By.CssSelector("img[alt='Proteus Fitness Jackshirt']"));
        private IWebElement proteusSizeBtn => _webDriver.FindElement(By.CssSelector("#option-label-color-93-item-49"));
        private IWebElement proteusColorBtn => _webDriver.FindElement(By.CssSelector("#option-label-color-93-item-49"));
        private IWebElement proteusAdToCartBtn => _webDriver.FindElement(By.CssSelector("button[id='product-addtocart-button'] span"));

        // Product 2
        private IWebElement montanaSizeBtn => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(4) > div:nth-child(4) > div:nth-child(1) > div:nth-child(4) > ol:nth-child(1) > li:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)"));
        private IWebElement montanaColorBtn => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(4) > div:nth-child(4) > div:nth-child(1) > div:nth-child(4) > ol:nth-child(1) > li:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(4) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1)"));
        private IWebElement montanaAdToCartBtn => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(4) > div:nth-child(4) > div:nth-child(1) > div:nth-child(4) > ol:nth-child(1) > li:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(5) > div:nth-child(1) > div:nth-child(1) > form:nth-child(1) > button:nth-child(4) > span:nth-child(1)"));

        // Product 3
        private IWebElement cronusDetailBtn => _webDriver.FindElement(By.CssSelector("img[alt='Cronus Yoga Pant ']"));
        private IWebElement cronusSizeBtn => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(4) > div:nth-child(4) > div:nth-child(1) > div:nth-child(4) > ol:nth-child(1) > li:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1)"));
        private IWebElement cronusColorBtn => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(4) > div:nth-child(4) > div:nth-child(1) > div:nth-child(4) > ol:nth-child(1) > li:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1)"));
        private IWebElement cronusAdToCartBtn => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(4) > div:nth-child(4) > div:nth-child(1) > div:nth-child(4) > ol:nth-child(1) > li:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > form:nth-child(1) > button:nth-child(4) > span:nth-child(1)"));

        // Verify Order IDs
       

        // Product Action Method
        public void clickProteusDetailBtn() => proteusDetailBtn.Click();
        public void clickProteusSizeBtn() => proteusSizeBtn.Click();
        public void clickProteusColorBtn() => proteusColorBtn.Click();
        public void clickProteusAdToCartBtn() => proteusAdToCartBtn.Click();
        public void clickMontanaSizeBtn() => montanaSizeBtn.Click();
        public void clickMontanaColorBtn() => montanaColorBtn.Click();
        public void clickMontanaAdToCartBtn() => montanaAdToCartBtn.Click();
        public void clickCronusDetailBtn() => cronusDetailBtn.Click();
        public void clickCronusSizeBtn() => cronusSizeBtn.Click();
        public void clickCronusColorBtn() => cronusColorBtn.Click();
        public void clickCronusAdToCartBtn() => cronusAdToCartBtn.Click();

        public void VerifyOrderId()
        {
            string orderId1 = _webDriver.FindElement(By.XPath("(//tr)[2]")).Text;
            Assert.IsTrue(orderId1.Contains("000009298"));
        }


}
}
