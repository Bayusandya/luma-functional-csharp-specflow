using luma.Drivers;
using luma.PageObjects;
using TechTalk.SpecFlow;

namespace luma.Steps
{
    [Binding]
    public sealed class CartStepDefinition
    {

        private readonly LoginPage _login;
        private readonly Navigation _nav;
        private readonly Act _act;
        private readonly Checkout _check;
        private readonly MyAccountPage _acountPage;
        private readonly Orders _order;

        public CartStepDefinition(BrowserDriver browserDriver)
        {
            _nav = new Navigation(browserDriver.Current);
            _login = new LoginPage(browserDriver.Current);
            _act = new Act(browserDriver.Current);
            _check = new Checkout(browserDriver.Current);
            _acountPage = new MyAccountPage(browserDriver.Current);
            _order = new Orders(browserDriver.Current);
        }

        [Given(@"that user do login")]
        public void GivenThatUserDoLogin()
        {
            _login.GoToHomePage();
            _login.clickSigninMenuBtn();
            _login.fillEmailField();
            _login.fillPasswordField();
            _login.clickSigninBtn();
        }

        [Given(@"user go to man section")]
        public void GivenUserGoToManSection()
        {
            _nav.GoToMenSectionPage();
        }

        [Given(@"user go to the jacket section")]
        public void GivenUserGoToTheJacketSection()
        {
            _nav.GoToMenJacketsPage();
        }

        [Given(@"user adding the first jackets to the cart")]
        public void GivenUserAddingTheFirstJacketsToTheCart()
        {
            _order.clickProteusDetailBtn();
            _order.clickProteusSizeBtn();
            _order.clickProteusColorBtn();
            _order.clickProteusAdToCartBtn();
        }

        [Given(@"user adding the second jackets to the cart")]
        public void GivenUserAddingTheSecondJacketsToTheCart()
        {
            _nav.GoToMenJacketsPage();
            _order.clickProteusDetailBtn();
            _order.clickMontanaSizeBtn();
            _order.clickMontanaColorBtn();
            _order.clickMontanaAdToCartBtn();
        }

        [Given(@"user go back to the  man section")]
        public void GivenUserGoBackToTheManSection()
        {
            _nav.GoToMenSectionPage();
        }

        [Given(@"user go to the pants section")]
        public void GivenUserGoToThePantsSection()
        {
            _nav.clickPantsMenuBtn();
        }

        [Given(@"user adding the pants to the cart")]
        public void GivenUserAddingThePantsToTheCart()
        {
            _order.clickCronusDetailBtn();
            _order.clickCronusSizeBtn();
            _order.clickCronusColorBtn();
            _order.clickCronusAdToCartBtn();
        }

        [Given(@"user click cart icon")]
        public void GivenUserClickCartIcon()
        {
            _nav.clickShowCartBtn();
        }

        [Given(@"user click proceed to checkout button")]
        public void GivenUserClickProceedToCheckoutButton()
        {
            _nav.clickTopCartCheckoutBtn();
        }

        [Given(@"user fill company name")]
        public void GivenUserFillCompanyName()
        {
            _act.fillCompanyField();
        }

        [Given(@"user fill city")]
        public void GivenUserFillCity()
        {
            _act.fillCityField();
        }

        [Given(@"user choose state or province")]
        public void GivenUserChooseStateOrProvince()
        {
            _act.clickStateProvinceChooseBtn();
            _act.clickAlabamaStateBtn();
        }

        [Given(@"user fill zip or postal code")]
        public void GivenUserFillZipOrPostalCode()
        {
            _act.fillZipcodeField();
        }

        [Given(@"user choose country")]
        public void GivenUserChooseCountry()
        {
            _act.clickCountryChooseBtn();
            _act.clickUsCountryBtn();
        }

        [Given(@"user fill phone number")]
        public void GivenUserFillPhoneNumber()
        {
            _act.fillPhoneNumberField();
        }

        [Given(@"user choose shipping methods")]
        public void GivenUserChooseShippingMethods()
        {
            _act.clickShippingChooseBtn();
        }

        [Given(@"user click next")]
        public void GivenUserClickNext()
        {
            _act.clickNextShippingBtn();
        }

        [Given(@"user verify the order summary")]
        public void GivenUserVerifyTheOrderSummary()
        {
            _check.VerifyOrderSummary();
        }

        [Given(@"user place an order")]
        public void GivenUserPlaceAnOrder()
        {
            _nav.clickPlaceOrderBtnn();
        }

        [Given(@"user go to my account page")]
        public void GivenUserGoToMyAccountPage()
        {
            _nav.GoToMyAccount();
        }

        [Given(@"user go to my order page")]
        public void GivenUserGoToMyOrderPage()
        {
            _acountPage.clickMyOrderPage();
        }

        [When(@"user verify the order")]
        public void WhenUserVerifyTheOrder()
        {
            _order.VerifyOrderId();
        }

        [Then(@"the order successful")]
        public void ThenTheOrderSuccessful()
        {

        }

    }
}
