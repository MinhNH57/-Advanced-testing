using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThuTest
{
    internal class SeleniumTest
    {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public async Task TestSelenium1()
        {
            driver.Navigate().GoToUrl("https://vitimex.com.vn/ao-so-mi-ngan-tay-pc28.html");

            // Đợi cho phần tử có thể click
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement user = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/header/div[2]/div/div[2]/div[2]/div[2]")));
            user.Click();

            // Thay vì Thread.Sleep, tiếp tục dùng WebDriverWait để đảm bảo phần tử sẵn sàng
            IWebElement SignUp = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[4]/div/div/div/div[1]/div[3]/a[1]")));
            SignUp.Click();

            IWebElement Name = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div[1]/div/form/div[1]/input")));
            Name.SendKeys("Nguyen Hong Minh");

            IWebElement Phone = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div[1]/div/form/div[2]/input")));
            Phone.SendKeys("0981688583");

            IWebElement Email = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div[1]/div/form/div[3]/input")));
            Email.SendKeys("namchu2003x1@gmail.com");

            IWebElement Pass = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div[1]/div/form/div[4]/input")));
            Pass.SendKeys("Minh123@");

            IWebElement PassConfirm = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div[1]/div/form/div[5]/input")));
            PassConfirm.SendKeys("Minh123@");

            IWebElement b = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div[1]/div/form/div[6]")));
            b.Click();
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://vitimex.com.vn/ao-so-mi-ngan-tay-pc28.html");

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement user = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/header/div[2]/div/div[2]/div[2]/div[2]")));
            user.Click();

            IWebElement TK = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[4]/div/div/div/div[1]/form/div[1]/div[1]/input")));
            TK.SendKeys("0981688583");

            IWebElement MK = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[4]/div/div/div/div[1]/form/div[1]/div[2]/input")));
            MK.SendKeys("Minh123@");

            IWebElement button = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[4]/div/div/div/div[1]/form/div[2]")));
            button.Click();
        }
    }
}
