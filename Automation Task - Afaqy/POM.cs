using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Automation_Task
{
    class Page
    {

        IWebDriver webDriver;

        [Obsolete]
        public Page(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-toggle' and contains(.,'Desktops')]")]
        public IWebElement Desktop { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='see-all' and contains(.,'Show All Desktops')]")]
        public IWebElement Desktop_All { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='http://tutorialsninja.com/demo/index.php?route=product/product&path=20&product_id=46' and contains(.,'Sony VAIO')]")]
        public IWebElement Sony_VAIO { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#input-quantity")]
        public IWebElement Qty { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-primary.btn-lg.btn-block")]
        public IWebElement Add_To_Cart { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='http://tutorialsninja.com/demo/index.php?route=checkout/cart' and contains(.,'shopping cart')]")]
        public IWebElement Shopping_Cart { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='http://tutorialsninja.com/demo/index.php?route=checkout/checkout' and @class='btn btn-primary']")]
        public IWebElement Checkout { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Continue']")]
        public IWebElement Continue { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-firstname']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-lastname']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-email']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-telephone']")]
        public IWebElement Telephone { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-password']")]
        public IWebElement Pass { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-confirm']")]
        public IWebElement ConfirmPass { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-address-1']")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-city']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='input-payment-postcode']")]
        public IWebElement Postal { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='input-payment-country']")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='input-payment-zone']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='agree']")]
        public IWebElement Checkbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='button-register']")]
        public IWebElement Continue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='button-shipping-address']")]
        public IWebElement Continue2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='button-shipping-method']")]
        public IWebElement Continue3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and '@name=agree']")]
        public IWebElement Checkbox2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='button-payment-method']")]
        public IWebElement Continue4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='button-confirm']")]
        public IWebElement ConfirmOrder { get; set; }

    }
}
