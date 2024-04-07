using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ASM_GD2.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {
        private IWebDriver driver { get; set; }

        [Given("Truy cập trang web đăng nhập: (.*)")]
        public void GivenLoginUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }

        [Given("Nhập username: (.*)")]
        public void GivenUsername(string username)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("username")).SendKeys(username);
        }

        [Given("Nhập password: (.*)")]
        public void GivenPassword(string password)
        {
            driver.FindElement(By.Id("password")).SendKeys(password);
        }

        [Given("Bấm nút Login")]
        public void BamNutLogin()
        {
            driver.FindElement(By.Id("LoginBtn")).Click();
        }

        [Then("Đăng nhập thành công")]
        public void LoginSuccess()
        {
            Thread.Sleep(3000);
            var url = driver.Url;
            driver.Quit();
            Assert.AreNotEqual(url, "http://localhost:5027/Home/Login");
        }

        [Then("Đăng nhập thất bại")]
        public void LoginFail()
        {
            Thread.Sleep(3000);
            var url = driver.Url;
            driver.Quit();
            Assert.AreEqual(url, "http://localhost:5027/Home/Login");
        }
    }
}
