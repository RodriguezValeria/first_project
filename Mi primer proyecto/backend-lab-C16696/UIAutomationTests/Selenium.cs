using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UIAutomationTests
{
    public class Selenium
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Select_Button_Test()
        {
            // Arrange
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            // Act
            var button = _driver.FindElement(By.XPath("//button[contains(text(), 'Agregar')]"));
            button.Click();

            var nameField = wait.Until(driver => driver.FindElement(By.Id("name")));
            nameField.SendKeys("Corea del Sur");

            var continentSelectElement = wait.Until(driver => driver.FindElement(By.Id("continente")));
            var continentSelect = new SelectElement(continentSelectElement);
            continentSelect.SelectByText("Asia");

            var languageField = wait.Until(driver => driver.FindElement(By.Id("idioma")));
            languageField.SendKeys("Coreano");

            // Assert
            var buttonSave = _driver.FindElement(By.XPath("//button[contains(text(), 'Guardar')]"));
            buttonSave.Click();
        }

    }
}
