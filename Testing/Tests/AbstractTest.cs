using System;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Testing.Lib;
using TestProject1.Enums;
using WebDriverManager;
using WebDriverManager.DriverConfigs;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

[assembly: Parallelizable(ParallelScope.All)]

namespace TestProject1.Tests
{
    public abstract class AbstractTest : IDisposable
    {
        private IWebDriver _driver;
        protected AppLib App { get; private set; }
        
        public void Dispose()
        {
            _driver.Quit();
        }

        private void SetUpDriver(DriverName browserName)
        {
            IDriverConfig driverConfig;
            switch (browserName)
            {
                case DriverName.CHROME:
                    driverConfig = new ChromeConfig();
                    new DriverManager().SetUpDriver(driverConfig, VersionResolveStrategy.MatchingBrowser);
                    _driver = new ChromeDriver();
                    break;
                case DriverName.FIREFOX:
                    driverConfig = new FirefoxConfig();
                    new DriverManager().SetUpDriver(driverConfig);
                    _driver = new FirefoxDriver();
                    break;
                default:
                    throw new Exception("You add browser name to enum, but forget to describe behaviour for it");
            }
        }

        [SetUp]
        public void Setup()
        {
            SetUpDriver(DriverName.CHROME);
            App = new AppLib(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}