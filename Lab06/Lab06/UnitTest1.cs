using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab06
{
    public class Tests
    {
        private IWebDriver drive;
        [SetUp]
        public void Setup()
        {
            drive = new ChromeDriver();
            drive.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            drive.Navigate().GoToUrl("https://www.google.com/");
            IWebElement serach_element = drive.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea"));
            serach_element.SendKeys("Messsi");
            serach_element.SendKeys(Keys.Enter);
        }

        [Test]
        public void ChangeFrame()
        {
            drive.Navigate().GoToUrl("https://howkteam.vn/course/turn-off-webrtc-voi-selenium-trong-wpf/turn-off-webrtc-voi-selenium-trong-wpf-2589");
            IWebElement ytb = drive.FindElement(By.Id("ytplayer"));
            ytb.Click();
            drive.SwitchTo().Frame(ytb);
            var ytb_frame = drive.FindElement(By.CssSelector(".ytp-youtube-button"));
            ytb_frame.Click();
        }

        [Test]
        public void LMS()
        {
            drive.Navigate().GoToUrl("https://fpl1.poly.edu.vn/login.php?target=&client_id=fpolyhn&auth_stat=");


            IWebElement DN = drive.FindElement(By.XPath("/html/body/div[1]/main/div/div/div/div/div/div[3]/div[3]/div/div/div[3]/div/div[3]/a"));
            DN.Click();
            IWebElement TK = drive.FindElement(By.Id("identifierId"));
            TK.SendKeys("minhnhph45057@fpt.edu.vn");
            TK.SendKeys(Keys.Enter);
        }

        [Test]
        public void LMS_TimKiem()
        {
            drive.Navigate().GoToUrl("https://fpl1.poly.edu.vn/login.php?target=&client_id=fpolyhn&auth_stat=");
            IWebElement email_input = drive.FindElement(By.XPath("/html/body/div[1]/header/div/ul/li[2]"));
            email_input.Click();

            IWebElement input1 = drive.FindElement(By.Id("main_menu_search"));
            input1.SendKeys("Ha Noi");
            input1.SendKeys(Keys.Enter);
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(1000);
            drive.Quit();
            drive.Dispose();
        }
    }
}