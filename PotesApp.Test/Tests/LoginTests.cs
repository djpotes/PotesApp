using PotesApp.Test.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MiProyecto.Tests.Tests;

public class LoginTests
{
    private IWebDriver _driver;

    [SetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
    }

    [Test]
    public void TestLoginExitoso()
    {
        var loginPage = new LoginPage(_driver);
        loginPage.Login("student", "Password123");

        // Agregar aserciones aquí
        Assert.Pass();
    }

    [TearDown]
    public void Teardown() => _driver.Quit();
}