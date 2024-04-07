using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ASM_GD2.StepDefinitions
{
    [Binding]
    public sealed class RegisterSteps
    {
        private IWebDriver driver { get; set; }

        [Given("Truy cập trang web đăng ký: (.*)")]
        public void GivenRegisterUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
        }

        [Given("Đăng ký với thông tin:")]
        public void GivenData(Table data)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Name")).SendKeys(data.Rows[0][0]);
            driver.FindElement(By.Id("UserName")).SendKeys(data.Rows[0][1]);
            driver.FindElement(By.Id("Password")).SendKeys(data.Rows[0][2]);
            driver.FindElement(By.Id("Email")).SendKeys(data.Rows[0][3]);
            driver.FindElement(By.Id("SDT")).SendKeys(data.Rows[0][4]);
            driver.FindElement(By.Id("NgaySinh")).SendKeys(data.Rows[0][5]);
            driver.FindElement(By.Id("DiaChi")).SendKeys(data.Rows[0][6]);
        }

        [When("Nhấn nút đăng ký")]
        public void BamNutRegister()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()='ĐĂNG KÝ']")).Click();
        }

        [Then("Hiển thị thông báo: (.*)")]
        public void RegisterResult(string result)
        {
            Thread.Sleep(2000);
            var thongBao = driver.FindElement(By.ClassName("swal-title")).Text;
            driver.Quit();
            Assert.IsTrue(thongBao.Contains(result));
        }
    }
}
