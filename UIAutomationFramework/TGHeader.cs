using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UIAutomationFramework;

[TestFixture]
public class Tests
{
    public IWebDriver driver;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        driver.Navigate().GoToUrl("https://techglobal-training.com/");
    }
   
    [Test]
    public void validateTGLogo()
    {
        IWebElement logo = driver.FindElement(By.Id("logo"));
        Assert.True(logo.Displayed);
    }

    [Test]
    public void validateTGHeading()
    { 

        IWebElement heading = driver.FindElement(By.CssSelector(".HomePage_pageTitle__UAMbk"));
        Assert.True(heading.Displayed);
        Assert.That(heading.Text.Equals("Welcome to TechGlobal School\nTraining"));
  
    }

    [TearDown]
    public void TearDown()
    {
        Thread.Sleep(3000);
        driver.Quit();
    }

}
