using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class ManageListings_delete
    {
        [Given(@"I launch the browser and click on managelisting")]
        public void GivenILaunchTheBrowserAndClickOnManagelisting()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Managelistings tab
            Driver.driver.FindElement(By.LinkText("Manage Listings")).Click();

        }

        [When(@"I select a particular service to delete and click on delete")]
        public void WhenISelectAParticularServiceToDeleteAndClickOnDelete()
        {
            //create list of data from table
            IList<IWebElement> listofService = Driver.driver.FindElements(By.XPath("//tr/td[3][@class='two wide']"));
            Console.WriteLine(listofService.Count);

            foreach (var list in listofService)
            {
                Console.WriteLine(list.Text);

                //select language to be deleted
                if (list.Text.Contains("Selenium"))
                {
                    Thread.Sleep(1000);
                    //Click on delete icon
                    Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Selenium')]//..//following-sibling::td//i[@class='remove icon']")).Click();
                    //Click on confirm delete
                    Driver.driver.FindElement(By.XPath("//div/button[@class='ui icon positive right labeled button']")).Click();
                    break;
                }
                else
                {

                    Console.WriteLine("Error");
                }


            }


        }

        [Then(@"the serevice should be deleted\.")]
        public void ThenTheSereviceShouldBeDeleted_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete a service");

                Thread.Sleep(1000);
                string ExpectedValue = "Selenium has been deleted";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted service");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Deleted service");
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
}
