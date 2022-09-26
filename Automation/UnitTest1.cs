using Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ActionsClass
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ThreadWaitimplicit()
        {


            //WebDriverManager.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.ebay.com.au/";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/a"));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            //Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/div[2]/div[1]/nav[2]/ul/li[1]/a")).Click();
            //driver.Quit();


        }
        [TestMethod]
        public void Alerts()
        {
            IWebDriver driver = new ChromeDriver();

            // new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

            string name = "Rahul";
            driver.FindElement(By.CssSelector("#name")).SendKeys(name);
            driver.FindElement(By.CssSelector("#confirmbtn")).Click();
            Thread.Sleep(3000);
            string alertText = driver.SwitchTo().Alert().Text;
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();
            // driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);

            StringAssert.Contains(name, alertText);

        }
        [TestMethod]
        public void ThreadExplicitWait()
        {


            //WebDriverManager.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.ebay.com.au/";

            driver.Manage().Window.Maximize();

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/a"));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"mainContent\"]/ div[1]/ul/li[3]/div[2]/div[1]/nav[2]/ul/li[1]/a"))).Click();




        }
        [TestMethod]
        public void Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Switchto";
            driver.SwitchTo().Frame("iframe_a");
            driver.FindElement(By.Id("name")).SendKeys("abc");
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.LinkText("uitestpractice.com")).Click();
            Thread.Sleep(2000);
            driver.Quit();




        }

        [TestMethod]
        public void IFrame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/guru99home/";
            driver.SwitchTo().Frame("a077aa5e");
            driver.FindElement(By.XPath("html/body/a/img")).Click();
            // driver.SwitchTo().DefaultContent();
            // driver.FindElement(By.LinkText("uitestpractice.com")).Click();
            Thread.Sleep(6000);
            driver.Quit();




        }
        [TestMethod]
        public void IFrameW3()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://www.w3schools.com/html/tryit.asp?filename=tryhtml_form_submit";

            driver.SwitchTo().Frame("iframeResult");
            //driver.SwitchTo().Frame(1);


            driver.FindElement(By.Name("fname")).SendKeys("AZ");

            driver.SwitchTo().ParentFrame();



            Thread.Sleep(5000);






            driver.Quit();




        }



        [TestMethod]
        public void Alerts1()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
        https://www.w3schools.com/js/tryit.asp?filename=tryjs_alert

            string name = "Rahul";
            driver.FindElement(By.CssSelector("#name")).SendKeys(name);
            driver.FindElement(By.CssSelector("#confirmbtn")).Click();
            Thread.Sleep(3000);
            string alertText = driver.SwitchTo().Alert().Text;
            Thread.Sleep(3000);

            driver.SwitchTo().Alert().Accept();
            // driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);

            StringAssert.Contains(name, alertText);




        }
        [TestMethod]
        public void AlertsW3()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://www.w3schools.com/js/tryit.asp?filename=tryjs_prompt";
            driver.SwitchTo().Frame("iframeResult");
            driver.FindElement(By.XPath("/html/body/button")).Click();
            driver.SwitchTo().Alert().SendKeys("AutomationZone");
            // Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);

            driver.SwitchTo().ParentFrame();
            driver.Quit();

        }
        [TestMethod]
        public void Dropdown12()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://demoqa.com/select-menu";

            // var se = driver.FindElement(By.XPath("//*[@id=\"mySelect\"]"));
            var se = driver.FindElement(By.Id("selectOne"));

            Thread.Sleep(5000);
            var SelectElement = new SelectElement(se);

            SelectElement.SelectByText("Green");







        }

        [TestMethod]
        public void Dropdown13()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            IWebElement dropdown = driver.FindElement(By.CssSelector("select.form-control"));
            SelectElement s = new SelectElement(dropdown);


            s.SelectByText("Teacher");
            Thread.Sleep(2000);







        }
        [TestMethod]
        public void PrintingProductNAmes()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://www.amazon.com/s?i=mobile&bbn=7072561011&rh=n%3A7072561011%2Cp_36%3A-30000%2Cp_72%3A2491149011&dc&fs=true&language=en_US&qid=1614961572&rnid=2491147011&ref=sr_pg_");
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("h2>a>span"));
            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text);
            }


        }

        [TestMethod]
        public void PrintingProductNAmes2()
        {
            IWebDriver driver = new ChromeDriver();


            driver.Navigate().GoToUrl("https://www.amazon.com/b?node=24230809011&ref=dlx_deals_gd_dcl_img_0_0de5fc54_dt_sl15_b4");
            IList<IWebElement> elements = driver.FindElements(By.CssSelector("#a-page > div.a-container > div.a-row.apb-browse-two-col-center-pad > div.a-column.a-span12.aok-float-right.apb-browse-col-pad-left.apb-browse-two-col-center-margin-right > div:nth-child(2) > div"));
            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text);
            }


        }
        [TestMethod]
        public void WikiPediaAutomation()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            var searchBox = driver.FindElement(By.Id("searchLanguage"));

            var selectElement = new SelectElement(searchBox);
            selectElement.SelectByText("Afrikaans");

        }

        [TestMethod]
        public void AmazonAutomation()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://www.amazon.com/b?node=24230809011&ref=dlx_deals_gd_dcl_img_0_0de5fc54_dt_sl15_b4");
            IWebElement searchBox = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
            IWebElement searchBtn = driver.FindElement(By.CssSelector("#nav-search-submit-button"));



            searchBox.SendKeys("iphone 11");
            searchBtn.Submit();
            IWebElement IphoneX = driver.FindElement(By.CssSelector("#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(2) > div > div > div > div > div > div.sg-col.sg-col-4-of-12.sg-col-8-of-16.sg-col-12-of-20.s-list-col-right > div > div > div.a-section.a-spacing-none.puis-padding-right-small.s-title-instructions-style > h2 > a > span"));
            IphoneX.Click();

            var dropdownSelect = driver.FindElement(By.Id("quantity"));


            var selectElement = new SelectElement(dropdownSelect);

            selectElement.SelectByText("2");

        }
        [TestMethod]

        public void Amazon3()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://www.amazon.com/b?node=24230809011&ref=dlx_deals_gd_dcl_img_0_0de5fc54_dt_sl15_b4");
            IWebElement searchBox = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
            IWebElement searchBtn = driver.FindElement(By.CssSelector("#nav-search-submit-button"));
            //IWebElement ADDCard = driver.FindElement(By.XPath("//*[@id=\"add - to - cart - button\"]"));


            searchBox.SendKeys("realme");
            searchBtn.Submit();
            driver.Navigate().GoToUrl("https://www.amazon.com/Dual-SIM-Factory-Unlocked-Android-Smartphone/dp/B099RL77BC/ref=sr_1_1?keywords=realme&qid=1662383781&sr=8-1");
            IWebElement Addcart = driver.FindElement(By.Id("add - to - cart - button"));
            Addcart.Click();



            // IWebElement IphoneX = driver.FindElement(By.CssSelector("#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(2) > div > div > div > div > div > div > div > div.sg-col.sg-col-4-of-12.sg-col-8-of-16.sg-col-12-of-20.s-list-col-right > div > div > div.a-section.a-spacing-none.puis-padding-right-small.s-title-instructions-style > h2 > a > span"));
            //IphoneX.Click();
            //ADDCard.Click();

            //var dropdownSelect = driver.FindElement(By.Id("quantity"));

            // var selectElement = new SelectElement(dropdownSelect);

            // selectElement.SelectByText("2");

        }
        [TestMethod]
        public void IFRAMEAmazonAutomation()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://www.amazon.com/b?node=24230809011&ref=dlx_deals_gd_dcl_img_0_0de5fc54_dt_sl15_b4");
            IWebElement searchBox = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
            IWebElement searchBtn = driver.FindElement(By.CssSelector("#nav-search-submit-button"));


            //  IWebElement addCard = driver.FindElement(By.XPath("//*[@id=\"add - to - cart - button\"]"));


            searchBox.SendKeys("iphone 11");
            searchBtn.Submit();
            IWebElement IphoneX = driver.FindElement(By.CssSelector("#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(2) > div > div > div > div > div > div.sg-col.sg-col-4-of-12.sg-col-8-of-16.sg-col-12-of-20.s-list-col-right > div > div > div.a-section.a-spacing-none.puis-padding-right-small.s-title-instructions-style > h2 > a > span"));
            IphoneX.Click();
            //addCard.Click();
            driver.SwitchTo().Frame("ape_Detail_customer-reviews-top_Glance_iframe");
            //driver.SwitchTo().Frame(1);


            IWebElement click1 = driver.FindElement(By.CssSelector("#ad > div > div > div.h-full.w-full.relative > div > div:nth-child(1) > a"));
            click1.Click();
            //IWebElement preorderButton = driver.FindElement(By.XPath("//*[@id=\"add - to - cart - button\"]"));
            // preorderButton.Click();



            driver.SwitchTo().ParentFrame();



        }

        [TestMethod]
        public void AmazonDropdown()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://www.amazon.com/ref=nav_logo");
            var Dropdown = driver.FindElement(By.CssSelector("#searchDropdownBox"));


            SelectElement element = new SelectElement(Dropdown);
            element.SelectByText("Baby");
            //// var selectElement = new SelectElement(searchBox);
            // selectElement.SelectByText("Afrikaans");

        }



        [TestMethod]
        public void AmazonAutomation14()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://www.amazon.com/b?node=24230809011&ref=dlx_deals_gd_dcl_img_0_0de5fc54_dt_sl15_b4");
            IWebElement searchBox = driver.FindElement(By.CssSelector("#twotabsearchtextbox"));
            IWebElement searchBtn = driver.FindElement(By.CssSelector("#nav-search-submit-button"));
            // IWebElement addCart = driver.FindElement(By.CssSelector("#add-to-cart-button"));




            searchBox.SendKeys("iphone 11");
            searchBtn.Submit();
            IWebElement IphoneX = driver.FindElement(By.CssSelector("#search > div.s-desktop-width-max.s-desktop-content.s-opposite-dir.sg-row > div.s-matching-dir.sg-col-16-of-20.sg-col.sg-col-8-of-12.sg-col-12-of-16 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div:nth-child(2) > div > div > div > div > div > div.sg-col.sg-col-4-of-12.sg-col-8-of-16.sg-col-12-of-20.s-list-col-right > div > div > div.a-section.a-spacing-none.puis-padding-right-small.s-title-instructions-style > h2 > a > span"));
            IphoneX.Click();

            // addCart.Click();    







        }

        [TestMethod]
        public void AutomationWEBCode()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("http://webcode.me/submit/");
            var form = driver.FindElement(By.TagName("form"));
            var name = driver.FindElement(By.Name("name"));
            var message = driver.FindElement(By.Name("message"));

            name.SendKeys("John Doe");
            message.SendKeys("Hello!");

            form.Submit();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            var content = driver.FindElement(By.TagName("body")).Text;




        }
        [TestMethod]
        public void AutomationPractice()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");



            //Click on Sign in
            driver.FindElement(By.LinkText("Sign in")).Click();

            //Enter email address
            driver.FindElement(By.CssSelector("[name='email_create']")).SendKeys("valdrinq@hotmail.com");

            //Click on "Create an account"
            driver.FindElement(By.XPath("//button[@name=\"SubmitCreate\"]")).Click();

            //Select Title
            driver.FindElement(By.XPath("//input[@id=\"id_gender1\"]")).Click();
            driver.FindElement(By.Name("customer_firstname")).SendKeys("Test User");
            driver.FindElement(By.Name("customer_lastname")).SendKeys("Vsoft");
            driver.FindElement(By.Id("passwd")).SendKeys("PKR@PKR");

            // Enter your address
            driver.FindElement(By.Id("firstname")).SendKeys("Test User");
            driver.FindElement(By.Id("lastname")).SendKeys("Vsoft");
            driver.FindElement(By.Id("company")).SendKeys("Vsoft");
            driver.FindElement(By.Id("address1")).SendKeys("Test 81/1,2nd cross");
            driver.FindElement(By.Id("city")).SendKeys("XYZ");
            //Thread.Sleep(2000);

            // Select State
            IWebElement statedropdown = driver.FindElement(By.Name("id_state"));
            SelectElement oSelect = new SelectElement(statedropdown);
            oSelect.SelectByValue("5");
            //Thread.Sleep(2000);

            driver.FindElement(By.Name("postcode")).SendKeys("51838");

            // Select Country
            IWebElement countrydropDown = driver.FindElement(By.Name("id_country"));
            SelectElement oSelectC = new SelectElement(countrydropDown);
            oSelectC.SelectByText("United States");

            //Enter Mobile Number
            driver.FindElement(By.Id("phone_mobile")).SendKeys("234567890");
            driver.FindElement(By.XPath("//input[@name=\"alias\"]")).Clear();
            driver.FindElement(By.XPath("//input[@name=\"alias\"]")).SendKeys("Office");
            driver.FindElement(By.Name("submitAccount")).Click();
            String userText = driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/div/div/nav/div[1]/a")).Text;

            // Validate that user has created
            if(
                userText.Contains("Vsoft"))
            {
                Console.WriteLine("User Verified,Test case Passed");
            }
            else
            {
                Console.WriteLine("User Verification Failed,Test case Failed");
            }






        }
        [TestMethod]
        public void AutomationPracticeADDCard()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_product=7&controller=product");



            //Click on Sign in
            //driver.FindElement(By.LinkText("Sign in")).Click();

            //Enter email address
            driver.FindElement(By.CssSelector("#add_to_cart > button")).Click();

            //Click on "Create an account"
          //  driver.FindElement(By.XPath("//button[@name=\"SubmitCreate\"]")).Click();



        }
        [TestMethod]
        public void AutomationSearch()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().GoToUrl("https://www.google.com/imghp?hl=sq&authuser=0&ogbl");



            //Click on Sign in
            //driver.FindElement(By.LinkText("Sign in")).Click();

            //Enter email address
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[3]/div[3]/img")).Click();
            driver.FindElement(By.XPath("//*[@id=\"ow7\"]/ div[3]/c-wiz/div[2]/div/div[3]/div[2]/div/div[2]/span")).Click();
            IWebElement fileupload = driver.FindElement(By.XPath("//*[@id=\"ow7\"]/ div[3]/c-wiz/div[2]/div/div[3]/div[2]/c-wiz/div[2]/div"));
            fileupload.SendKeys(@"C: \Users\Lenovo\r.jpg");



            //Click on "Create an account"
            //  driver.FindElement(By.XPath("//button[@name=\"SubmitCreate\"]")).Click();



        }


        [TestMethod]
        public void WebDriverEventListeners()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            EventFiringWebDriver eventFiringWebDriver = new EventFiringWebDriver(driver);
            eventFiringWebDriver.Navigated += EventFiringWebDriver_Navigated;
            eventFiringWebDriver.NavigatedBack += EventFiringWebDriver_NavigatedBack;
            eventFiringWebDriver.NavigatedForward += EventFiringWebDriver_NavigatedForward;

            eventFiringWebDriver.ElementValueChanged += EventFiringWebDriver_ElementValueChanged;
            eventFiringWebDriver.ExceptionThrown += EventFiringWebDriver_ExceptionThrown;


            eventFiringWebDriver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            eventFiringWebDriver.Navigate().Back();
            eventFiringWebDriver.Navigate().Forward();

            eventFiringWebDriver.FindElement(By.Name("UserName")).SendKeys("admin");
            eventFiringWebDriver.FindElement(By.Name("Login")).Submit();


            eventFiringWebDriver.FindElement(By.Name("UserName")).SendKeys("admin");



        }

        private void EventFiringWebDriver_ExceptionThrown(object sender, WebDriverExceptionEventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyy_MM_dd_hhmm");
            ((ITakesScreenshot)e.Driver).GetScreenshot().SaveAsFile("Error_" + timestamp + ".png");
        }

        private void EventFiringWebDriver_ElementValueChanged(object sender, WebElementValueEventArgs e)
        {
            Console.WriteLine("Element value changed  " + e.Value);
        }

        private void EventFiringWebDriver_NavigatedForward(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Navigated forward " + e.Driver.Url);

        }

        private void EventFiringWebDriver_NavigatedBack(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Navigated back " + e.Driver.Url);

        }

        private void EventFiringWebDriver_Navigated(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Navigated to " + e.Url);

        }


        [TestMethod]
        public void WebDriverEventListenersWithCustomClass()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            EventFiringWebDriver eventFiringWebDriver = new CustomEventFiringHandler(driver);
            


            eventFiringWebDriver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            eventFiringWebDriver.Navigate().Back();
            eventFiringWebDriver.Navigate().Forward();

            eventFiringWebDriver.FindElement(By.Name("UserName")).SendKeys("admin");
            eventFiringWebDriver.FindElement(By.Name("Login")).Submit();


        }
    }
}

    



  






