using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Locators
{
    public class Tests
    {
        private IWebDriver _driver;

        private readonly By _elementForLink = By.LinkText("Winter Sports");
        private readonly By _elementForAssert = By.ClassName("sp-c-sport-navigation__link");
        private readonly By _elementForClassName = By.ClassName("orbit-search-button-icon-only");
        private readonly By _elementForId = By.Id("idcta-link"); 
        private readonly By _elementForXPath = By.XPath("(.//button[contains(@class,'qa-all-sport-button')])[1]");
            
        [SetUp]
        public void StartBrowser()
        {
            _driver = new ChromeDriver();

            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.bbc.com/sport");
        }

        [Test]
        public void SearchElementAndClickOn()
        {
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            _driver.FindElement(_elementForLink).Click();

            Assert.IsNotNull(_elementForAssert);
        }

        [Test]
        public void SearchElementForClassName()
        {
            Assert.IsNotNull(_elementForClassName);
        }

        [Test]
        public void SearchElementForId()
        {
            Assert.IsNotNull(_elementForId);
        }
       
        [TearDown]
        public void CloseBrowser()
        {
            _driver.Quit();
        }
    }
}