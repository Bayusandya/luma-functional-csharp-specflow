using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace luma.PageObjects
{
    class Act
    {
        private const string BaseUrl = "https://magento.softwaretestingboard.com/";
        private readonly IWebDriver _webDriver;
        public const int DefaultWaitInSeconds = 5;

        public Act(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void OpenBrowser()
        {
            if (_webDriver.Url != BaseUrl)
            {
                _webDriver.Url = BaseUrl;
            }
        }

        // Shipping Address Elements
        private IWebElement companyField => _webDriver.FindElement(By.Id("#A5GU9BP"));
        private IWebElement streetAddress => _webDriver.FindElement(By.Id("#RAEH0HO"));
        private IWebElement cityField => _webDriver.FindElement(By.Id("#GV8XE2H"));
        private IWebElement stateProvinceChooseBtn => _webDriver.FindElement(By.Id("#DYAGJD1"));
        private IWebElement alabamaStateBtn => _webDriver.FindElement(By.CssSelector("option[value='1']"));
        private IWebElement zipcodeField => _webDriver.FindElement(By.Id("#DPAISYR"));
        private IWebElement countryChooseBtn => _webDriver.FindElement(By.Id("#EPE1I9S"));
        private IWebElement usCountryBtn => _webDriver.FindElement(By.CssSelector("option[value='US']"));
        private IWebElement phoneNumberField => _webDriver.FindElement(By.Id("#M0GLQSY"));
        private IWebElement shippingChooseBtn => _webDriver.FindElement(By.Id("input[value='tablerate_bestway']"));
        private IWebElement proteusOrderSumItem => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(3) > aside:nth-child(8) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > ol:nth-child(1) > li:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > strong:nth-child(1)"));
        private IWebElement montanaOrderSumItem => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(3) > aside:nth-child(8) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > ol:nth-child(1) > li:nth-child(2) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > strong:nth-child(1)"));
        private IWebElement cronusOrderSumItem => _webDriver.FindElement(By.CssSelector("body > div:nth-child(5) > main:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(3) > aside:nth-child(8) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > ol:nth-child(1) > li:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > strong:nth-child(1)"));
        private IWebElement nextShippingBtn => _webDriver.FindElement(By.Id(".button.action.continue.primary"));

        //
        private IWebElement signinMenuBtn => _webDriver.FindElement(By.XPath("//div[@class='panel header']//a[contains(text(),'Sign In')]"));
        private IWebElement emailField => _webDriver.FindElement(By.Id("email"));
        private IWebElement passField => _webDriver.FindElement(By.Id("pass"));
        private IWebElement signinBtn => _webDriver.FindElement(By.Id("send2"));

        //
        private IWebElement showCartBtn => _webDriver.FindElement(By.CssSelector(".action.showcart"));
        private IWebElement topCartCheckoutBtn => _webDriver.FindElement(By.XPath("//span[normalize-space()='View and Edit Cart']"));
        private IWebElement pantsMenuBtn => _webDriver.FindElement(By.XPath("//a[contains(text(),'Pants')]"));

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

        //
        public void clickSigninMenuBtn() => signinMenuBtn.Click();
        public void fillEmailField() => emailField.SendKeys("bayusandya@yopmail.com");
        public void fillPasswordField() => passField.SendKeys("Pepsiman42_");
        public void clickSigninBtn() => signinBtn.Click();

        // Shipping Address Method
        public void fillCompanyField() => companyField.SendKeys("Others");
        public void fillStreetAddress() => streetAddress.SendKeys("5200 OAKWOOD ST BIRMINGHAM AL 35228-3781 USA");
        public void fillCityField() => cityField.SendKeys("BIRMINGHAM");
        public void clickStateProvinceChooseBtn() => stateProvinceChooseBtn.Click();
        public void clickAlabamaStateBtn() => alabamaStateBtn.Click();
        public void fillZipcodeField() => zipcodeField.SendKeys("35228-3781");
        public void clickCountryChooseBtn() => countryChooseBtn.Click();
        public void clickUsCountryBtn() => usCountryBtn.Click();
        public void fillPhoneNumberField() => phoneNumberField.SendKeys("082240204633");
        public void clickShippingChooseBtn() => shippingChooseBtn.Click();
        public void clickNextShippingBtn() => nextShippingBtn.Click();

        //
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

        //
        public void clickManBreadcumBtn() => cronusAdToCartBtn.Click();
        public void clickPantsMenuBtn() => pantsMenuBtn.Click();
        public void clickShowCartBtn() => showCartBtn.Click();
        public void clickTopCartCheckoutBtn() => topCartCheckoutBtn.Click();

        // Pages Method
        public void GoToPageJacket()
        {
            _webDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/men/tops-men/jackets-men.html");
        }
        public void GoToHomePage()
        {
            _webDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
        }

        public void wait()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
