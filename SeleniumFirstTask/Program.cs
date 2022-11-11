using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirstTask
{
    public class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            

        }

        [SetUp]
        public void Inicializacia()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement userName = driver.FindElement(By.Id("user-name"));
            userName.SendKeys("standard_user");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Submit();

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
    }
}
