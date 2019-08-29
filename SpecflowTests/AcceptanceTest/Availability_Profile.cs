using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;
using System.Collections.Generic;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Availability_Profile
    {
        [Given(@"I launch browser, signin and click on profile")]
        public void GivenILaunchBrowserSigninAndClickOnProfile()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Availability")]
        public void GivenIClickOnAvailability()
        {
            //Click on availability edit icon
            Driver.driver.FindElement(By.XPath("//div[2]/div[@class='right floated content']/span/i[@class='right floated outline small write icon']")).Click();

            
        }


        [When(@"I select availability option")]
        public void WhenISelectAvailabilityOption()
        {
            //Click on availability options
            Driver.driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyType']")).Click();


            SelectElement Availabilty = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='availabiltyType']")));
            Availabilty.SelectByIndex(1);

      
        }

        [Then(@"the result should display a message as ""(.*)""")]
        public void ThenTheResultShouldDisplayAMessageAs(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add availability");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a availabilitySuccessfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Availability Added");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {

                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}//Availability
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Hours_Profile
    {
        [Given(@"I launch the browser, signin and click on profile")]
        public void GivenILaunchTheBrowserSigninAndClickOnProfile()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on edit Hours icon")]
        public void GivenIClickOnEditHoursIcon()
        {
            //Click on Hours edit icon
            Driver.driver.FindElement(By.XPath("//div[3]/div[@class='right floated content']/span/i[@class='right floated outline small write icon']")).Click();

        }

        [When(@"I select options for Hours")]
        public void WhenISelectOptionsForHours()
        {
            //Click on Hours options
            Driver.driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyHour']")).Click();


            SelectElement Hours = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='availabiltyHour']")));
            Hours.SelectByIndex(1);

        }

        [Then(@"the result should display message as ""(.*)""")]
        public void ThenTheResultShouldDisplayMessageAs(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add hour availability");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a availabilitySuccessfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Availability Added");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {

                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}//Available Hours
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class EarnTarget_Profile
    {
        [Given(@"I launch the  browser, signin and click on profile")]
        public void GivenILaunchTheBrowserSigninAndClickOnProfile()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on EarnTarget edit icon")]
        public void GivenIClickOnEarnTargetEditIcon()
        {
            //Click on Earntarget edit icon
            Driver.driver.FindElement(By.XPath("//div[4]/div[@class='right floated content']/span/i[@class='right floated outline small write icon']")).Click();

        }

        [When(@"I select options for EarnTarget")]
        public void WhenISelectOptionsForEarnTarget()
        {
            //Click on availability options
            Driver.driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyTarget']")).Click();

            //Select option
            SelectElement Availabilty = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='availabiltyTarget']")));
            Availabilty.SelectByIndex(2);

        }

        [Then(@"the result should display the message as ""(.*)""")]
        public void ThenTheResultShouldDisplayTheMessageAs(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add availability");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added EarnTarget Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Availability Added");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {

                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}//EarnTarget


