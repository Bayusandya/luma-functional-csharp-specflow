using OpenQA.Selenium;

namespace luma.PageObjects
{
    class LoginPage
    {
        private const string BaseUrl = "https://magento.softwaretestingboard.com/";
        private readonly IWebDriver _webDriver;
        public const int DefaultWaitInSeconds = 5;

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //
        private IWebElement signinMenuBtn => _webDriver.FindElement(By.XPath("//div[@class='panel header']//a[contains(text(),'Sign In')]"));
        private IWebElement emailField => _webDriver.FindElement(By.Id("email"));
        private IWebElement passField => _webDriver.FindElement(By.Id("pass"));
        private IWebElement signinBtn => _webDriver.FindElement(By.Id("send2"));


        //
        public void clickSigninMenuBtn() => signinMenuBtn.Click();
        public void fillEmailField() => emailField.SendKeys("bayusandya@yopmail.com");
        public void fillPasswordField() => passField.SendKeys("Pepsiman42_");
        public void clickSigninBtn() => signinBtn.Click();

        public void GoToHomePage()
        {
            _webDriver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
        }
        public void GoToBaseUrl()
        {
            _webDriver.Navigate().GoToUrl(BaseUrl);
        }
    }
}
