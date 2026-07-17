using OpenQA.Selenium;

namespace PotesApp.Test.Pages;

public class LoginPage
{
    private readonly IWebDriver _driver;

    public LoginPage(IWebDriver driver) => _driver = driver;

    // Elementos
    private IWebElement UsernameField => _driver.FindElement(By.Id("username"));
    private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
    private IWebElement LoginButton => _driver.FindElement(By.Id("submit"));

    // Acciones
    public void Login(string email, string password)
    {
        UsernameField.SendKeys(email);
        PasswordField.SendKeys(password);
        LoginButton.Click();
    }
}