using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assert = NUnit.Framework.Assert;

namespace Selectors
{
    public class Selectors
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void RemoveItemFromCart()
        {
            //Добавляємо Cappuccino до кошика
            driver.Navigate().GoToUrl("https://coffee-cart.app/");

            //Тут необхідно знайти Cappuccino
            //driver.FindElement(By.CssSelector()).Click();

            //Тут необхідно знайти cart(1)
            //driver.FindElement(By.CssSelector()).Click();

            //Тут необхідно знайти кнопку видалення товару Cappuccino.
            //driver.FindElement(By.XPath())Click();

            // Перевіряємо, що товар більше не відображається.
            var emptyCartTitle = driver.FindElement(By.XPath("//p[text()='No coffee, go add some.']"));
            Assert.That(emptyCartTitle.Text, Is.EqualTo("No coffee, go add some."), "Cappuccino should be removed from the cart.");



            [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
