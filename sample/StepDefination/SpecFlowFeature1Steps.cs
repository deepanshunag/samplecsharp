using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace sample.StepDefination
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\deepanshusharma\Desktop\chromedriver_win32");
            driver.Navigate().GoToUrl("https://www.expedia.com/");
            Console.WriteLine("hello");
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("hello");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Console.WriteLine("hello");
        }
    }
}
