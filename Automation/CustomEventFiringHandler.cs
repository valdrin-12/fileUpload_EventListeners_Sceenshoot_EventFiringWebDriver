using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    internal class CustomEventFiringHandler : EventFiringWebDriver //override direct eventfiring
    {
        public CustomEventFiringHandler(IWebDriver parentDriver) : base(parentDriver)
        {
        }

        protected override void OnNavigatedBack(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("navigating back to :"+Url);
        }

        protected override void OnNavigatedForward(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("navigating forward to :" + Url);


        }



    }
}
