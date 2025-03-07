using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        // Initialize Chrome WebDriver
        IWebDriver driver = new ChromeDriver();

        // Navigate to Google
        driver.Navigate().GoToUrl("https://www.google.com");

        // Print Hello World in Console
        Console.WriteLine("Hello, World! Selenium is working!");

        // Close the browser
        driver.Quit();
    }
}
