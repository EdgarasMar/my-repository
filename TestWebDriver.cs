using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgramAuto
{
    class TestWebDriver
    {

        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";
            chrome.Quit();

        }
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://login.yahoo.com/";
            firefox.Quit();
        }
        [Test]


        public static void TestYahooPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";
            IWebElement loginInputField = chrome.FindElement(By.Id("login-username"));
            loginInputField.SendKeys("Test");
            IWebElement loginButton = chrome.FindElement(By.Id("login-signin"));
            loginButton.Click();
            // chrome.Quit();
        }

        [Test]

        public static void TestSeleniumPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement inputField = chrome.FindElement(By.Id("user-message"));
            string myText = "Cat";
            inputField.SendKeys(myText);
            //IWebElement buttonNop = chrome.FindElement(By.CssSelector(".btn.btn-default"));
            IWebElement button = chrome.FindElement(By.CssSelector("#get-input > button"));
            //IWebElement buttonNoppp = chrome.FindElement(By.XPath("//[@id='get-input']/button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            //Assert.IsTrue(myText.Equals(result), "No Text");
            Assert.AreEqual(myText, result.Text, "Testas neatsirado");
            chrome.Quit();
        }

        [Test]
        public static void TestSeleniumPageFirefox()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement inputField = firefox.FindElement(By.Id("user-message"));
            string myText = "Katinukai";
            inputField.SendKeys(myText);
            IWebElement button = firefox.FindElement(By.CssSelector("#get-input > button"));
            button.Click();
            IWebElement result = firefox.FindElement(By.Id("display"));
            //Assert.IsTrue(myText.Equals(result), "Tekstas neatsirado");
            Assert.AreEqual(myText, result.Text, "Tekstas neatsirado");
            firefox.Quit();

        }
    }
}
