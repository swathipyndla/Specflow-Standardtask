using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Add_Description
    {
        [Given(@"I launch browser and click on profile")]
        public void GivenILaunchBrowserAndClickOnProfile()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on edit description icon and enter some text")]
        public void GivenIClickOnEditDescriptionIconAndEnterSomeText()
        {
            //Click on edit description icon
            Driver.driver.FindElement(By.XPath("//h3[@class='ui dividing header']/span/i[@class='outline write icon']")).Click();

            //Click on description textbox
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).Click();

            //Clear text in description textbox
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).Clear();

            //Enter text into description
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).SendKeys("Helloo");


        }
        
        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
            Driver.driver.FindElement(By.XPath("//div[1]/div/div/button[@class='ui teal button' and contains(text(),'Save')]")).Click();
        }
        
        [Then(@"the description should be added successfully\.")]
        public void ThenTheDescriptionShouldBeAddedSuccessfully_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Description has been saved successfully";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Description saved Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Description saved");
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
} //Add Description
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Null_Description
    {
        [Given(@"I  launch browser and click on profile tab")]
        public void GivenILaunchBrowserAndClickOnProfileTab()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();


        }

        [Given(@"I click on edit icon in description and leave the field empty")]
        public void GivenIClickOnEditIconInDescriptionAndLeaveTheFieldEmpty()
        {
            //Click on edit description icon
            Driver.driver.FindElement(By.XPath("//h3[@class='ui dividing header']/span/i[@class='outline write icon']")).Click();

            //Click on description textbox
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).Click();

            //Clear text in description textbox
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).Clear();

            //Enter text into description
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).SendKeys("");

        }

        [When(@"I click on save button\.")]
        public void WhenIClickOnSaveButton_()
        {
            Driver.driver.FindElement(By.XPath("//div[1]/div/div/button[@class='ui teal button' and contains(text(),'Save')]")).Click();
        }

        [Then(@"it shows an error message ""(.*)""")]
        public void ThenItShowsAnErrorMessage(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Null value in description");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Description cannot be null");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Description cannot be null");
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
} //Null Description
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Description_Splcharecter
    {
        [Given(@"I launch browser and click on profile tab")]
        public void GivenILaunchBrowserAndClickOnProfileTab()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on edit  icon in description and enter some text with special charecter")]
        public void GivenIClickOnEditIconInDescriptionAndEnterSomeTextWithSpecialCharecter()
        {
            //Click on edit description icon
            Driver.driver.FindElement(By.XPath("//h3[@class='ui dividing header']/span/i[@class='outline write icon']")).Click();

            //Click on description textbox
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).Click();

            //Clear text in description textbox
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).Clear();

            //Enter text into description
            Driver.driver.FindElement(By.XPath("//textarea[@name='value' and @placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")).SendKeys("@Helloo");

        }

        [When(@"I click on save button to add description")]
        public void WhenIClickOnSaveButtonToAddDescription()
        {
            Driver.driver.FindElement(By.XPath("//div[1]/div/div/button[@class='ui teal button' and contains(text(),'Save')]")).Click();
        }

        [Then(@"it shows an error message  ""(.*)""")]
        public void ThenItShowsAnErrorMessage(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Description dont accept special characters");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Description not saved");
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
}//Special charecter_Description

