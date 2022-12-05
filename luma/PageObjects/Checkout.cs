using NUnit.Framework;
using OpenQA.Selenium;
namespace luma.PageObjects
{
    class Checkout
    {
        private readonly IWebDriver _webDriver;
        public const int DefaultWaitInSeconds = 5;

        public Checkout(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //Order Summary Assert Method
        public void VerifyOrderSummary()
        {
            string cartSubTotal = _webDriver.FindElement(By.CssSelector("span[data-th='Cart Subtotal']")).Text;
            string cartShipping = _webDriver.FindElement(By.CssSelector("span[data-th='Cart Subtotal']")).Text;
            string cartTotal = _webDriver.FindElement(By.CssSelector("span[data-th='Cart Subtotal']")).Text;
            string item1 = _webDriver.FindElement(By.CssSelector("body > div:nth-child(6) > main:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(3) > aside:nth-child(8) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > ol:nth-child(1) > li:nth-child(1) > div:nth-child(1) > div:nth-child(2)")).Text;
            string item2 = _webDriver.FindElement(By.CssSelector("body > div:nth-child(6) > main:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(3) > aside:nth-child(8) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > ol:nth-child(1) > li:nth-child(2) > div:nth-child(1) > div:nth-child(2)")).Text;
            string item3 = _webDriver.FindElement(By.CssSelector("body > div:nth-child(6) > main:nth-child(2) > div:nth-child(3) > div:nth-child(1) > div:nth-child(3) > aside:nth-child(8) > div:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > ol:nth-child(1) > li:nth-child(3) > div:nth-child(1) > div:nth-child(2)")).Text;

            Assert.IsTrue(item1.Contains("Proteus Fitness Jackshirt"));
            Assert.IsTrue(item2.Contains("Montana Wind Jacket"));
            Assert.IsTrue(item3.Contains("Cronus Yoga Pant"));
            Assert.IsTrue(cartSubTotal.Contains("142.00"));
            Assert.IsTrue(cartShipping.Contains("0.00"));
            Assert.IsTrue(cartTotal.Contains("142.00"));
        }

    }
}
