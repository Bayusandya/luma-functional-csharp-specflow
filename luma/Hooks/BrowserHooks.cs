using luma.Drivers;
using luma.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace luma.Hooks
{
    [Binding]
    class BrowserHooks
    {
        [BeforeScenario(" ")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var login = new LoginPage(browserDriver.Current);
            login.GoToBaseUrl();
        }
    }
}
