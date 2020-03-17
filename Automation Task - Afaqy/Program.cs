using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net;
using excel = Microsoft.Office.Interop.Excel;

namespace Automation_Task
{
    [TestFixture]

    class Afaqy
    {
        static void Main(string[] args)
        {
        }

        // Defining All Objects
        #region
        ChromeDriver webDriver;
        ChromeOptions options;
        ExtentReports extent;
        ExtentTest test;
        IJavaScriptExecutor Execute;
        WebDriverWait wait;
        OperatingSystem os = Environment.OSVersion;
        Page Page;
        string hostname = Dns.GetHostName();
        string Url;
        string Qty;
        string FirstName;
        string LastName;
        string Email;
        string Telephone;
        string Pass;
        string ConfirmPass;
        string Address;
        string City;
        string Postal;
        string Country;
        string State;

        #endregion

        [OneTimeSetUp]
        [Obsolete]
        public void intialize()
        {
            //Intialize Reading From Excel Sheet
            #region
            excel.Application Test_Data = new excel.Application();
            excel.Workbook Workbook = Test_Data.Workbooks.Open(@"C:\Users\hassan.farid\Documents\Automation_Task.xlsx");
            excel.Worksheet Sheets = Workbook.Sheets[1];
            excel.Range Range = Sheets.UsedRange;
            Url = Range.Cells[1][2].Value2.ToString();
            Qty = Range.Cells[2][2].Value2.ToString();
            FirstName = Range.Cells[3][2].Value2.ToString();
            LastName = Range.Cells[4][2].Value2.ToString();
            Email = Range.Cells[5][2].Value2.ToString();
            Telephone = Range.Cells[6][2].Value2.ToString();
            Pass = Range.Cells[7][2].Value2.ToString();
            ConfirmPass = Range.Cells[8][2].Value2.ToString();
            Address = Range.Cells[9][2].Value2.ToString();
            City = Range.Cells[10][2].Value2.ToString();
            Postal = Range.Cells[11][2].Value2.ToString();
            Country = Range.Cells[12][2].Value2.ToString();
            State = Range.Cells[13][2].Value2.ToString();
            #endregion

            //Intialize Writing in HTML Report
            #region
            extent = new ExtentReports();
            var htmlreporter = new ExtentHtmlReporter(@"D:\Report.html");
            htmlreporter.Config.DocumentTitle = "Automation Task";
            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent.AttachReporter(htmlreporter);
            extent.AddSystemInfo("Operating System", os.ToString());
            extent.AddSystemInfo("HostName", hostname);
            extent.AddSystemInfo("Browser", "Google Chrome");
            #endregion
        }

        [SetUp]
        [Obsolete]
        public void Setup()
        {
            //Setup of HTTP Response (Waiting Data Until it Retreived From DataBase is 3 min)
            #region
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            webDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));
            webDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
            #endregion

            //Maximize The Window
            #region
            webDriver.Manage().Window.Maximize();      //Maximize
            #endregion

            //Intialize Implicit Wait due to poor connection or slow internet speed is 100 sec
            #region
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            #endregion

            //Intialize JavaScriptExecutor
            #region
            Execute = (IJavaScriptExecutor)webDriver;
            #endregion

            //Intialize Explicit Wait (Until Loading Icon is Being Invisible)
            #region
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            #endregion

            //Intialize instance of Methods That is Called From Folder Methods
            #region
            Page = new Page(webDriver);
            #endregion

            //Intialize URL
            #region
            webDriver.Navigate().GoToUrl(Url);
            #endregion
        }

        [Test]
        [Order(1)]
        [Obsolete]
        public void Task()
        {
            test = extent.CreateTest("Task2");
            test.Log(Status.Info, "URL is Opened");

            Page.Desktop.Click();
            Page.Desktop_All.Click();
            Execute.ExecuteScript("arguments[0].scrollIntoView(true);", Page.Sony_VAIO);
            Page.Sony_VAIO.Click();
            Page.Qty.Click();
            Page.Qty.Clear();
            Page.Qty.SendKeys(Qty);
            Page.Add_To_Cart.Click();
            Page.Shopping_Cart.Click();
            Assert.IsTrue(webDriver.FindElement(By.XPath("//td[@class='text-center' and contains(.,'Image')]")).Displayed);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//td[@class='text-left' and contains(.,'Product Name')]")).Displayed);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//td[@class='text-left' and contains(.,'Model')]")).Displayed);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//td[@class='text-left' and contains(.,'Quantity')]")).Displayed);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//td[@class='text-right' and contains(.,'Unit Price')]")).Displayed);
            Assert.IsTrue(webDriver.FindElement(By.XPath("//table[@class='table table-bordered']/thead/tr/td[@class='text-right' and contains(.,'Total')]")).Displayed);
            Page.Checkout.Click();
            Page.Continue.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='input-payment-firstname']")));
            Page.FirstName.Click();
            Page.FirstName.SendKeys(FirstName);
            Page.LastName.Click();
            Page.LastName.SendKeys(LastName);
            Page.Email.Click();
            Page.Email.SendKeys(Email);
            Page.Telephone.Click();
            Page.Telephone.SendKeys(Telephone);
            Page.Address1.Click();
            Page.Address1.SendKeys(Address);
            Page.City.Click();
            Page.City.SendKeys(City);
            Page.Postal.Click();
            Page.Postal.SendKeys(Postal);
            Page.Country.Click();
            SelectElement Select_Country = new SelectElement(Page.Country);
            Select_Country.SelectByText(Country);
            Page.State.Click();
            SelectElement Select_State = new SelectElement(Page.State);
            Select_State.SelectByText(State);
            Page.Pass.Click();
            Page.Pass.SendKeys(Pass);
            Page.ConfirmPass.Click();
            Page.ConfirmPass.SendKeys(ConfirmPass);
            Page.Checkbox.Click();
            Page.Continue1.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='button-shipping-address']")));
            Page.Continue2.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='button-shipping-method']")));
            Page.Continue3.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='button-payment-method']")));
            Page.Checkbox2.Click();
            Page.Continue4.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='button-confirm']")));
            Page.ConfirmOrder.Click();

        }

        [TearDown]
        [Obsolete]
        public void End()
        {
            test.Log(Status.Info, "User Logout Successfully");
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var errormessage = TestContext.CurrentContext.Result.Message;
            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(Status.Fail, status + errormessage);
                ((ITakesScreenshot)webDriver).GetScreenshot().SaveAsFile(@"D:\Test_Case_Failed.png", ScreenshotImageFormat.Png);
            }
            else
            {
                test.Log(Status.Pass, status + errormessage);
                ((ITakesScreenshot)webDriver).GetScreenshot().SaveAsFile(@"D:\Test_Case_Passed.png", ScreenshotImageFormat.Png);
            }
            webDriver.Quit();
        }

        [OneTimeTearDown]
        public void Quit()
        {
            extent.Flush();
        }
    }
}