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
    class HWTestWeb
    {
        [Test]

        public static void Givin_PositiveNumber_When_WebCalkulator_Return_Result()
        {
            // Arange

            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";

            //Act

            IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
            string myText = "2";
            inputField1.SendKeys(myText);
            IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
            string myText2 = "2";
            inputField2.SendKeys(myText2);
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));

            //Assert
            Assert.AreEqual("4", result.Text, "Test is wrong");
            chrome.Quit();
        }

        [Test]

        public static void Givin_NegativeNumber_When_WebCalkulator_Return_Result()
        {
            // Arange

            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";

            //Act

            IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
            string myText = "-5";
            inputField1.SendKeys(myText);
            IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
            string myText2 = "3";
            inputField2.SendKeys(myText2);
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));

            //Assert

            Assert.AreEqual("-2", result.Text, "Wrong test");
            chrome.Quit();
        }

        [Test]

        public static void Givin_NotNumber_When_WebCalkulator_Return_NaNString()
        {
            // Arange

            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";

            //Act

            IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
            string myText = "a";
            inputField1.SendKeys(myText);
            IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
            string myText2 = "b";
            inputField2.SendKeys(myText2);
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));

            //Assert

            Assert.AreEqual("NaN", result.Text, "Test not working" );
            chrome.Quit();
        }
    }
}
