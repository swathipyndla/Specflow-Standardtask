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
    public class Certificate_Add
    {
        [Given(@"I open the browser and login to the portal")]
        public void GivenIOpenTheBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Certification under profile tab and click on Add New")]
        public void GivenIClickOnCertificationUnderProfileTabAndClickOnAddNew()
        {
            //Click on Certification tab
            Driver.driver.FindElement(By.LinkText("Certifications")).Click();

            //Click on Add new
            Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div/div/table/thead/tr/th[@class='right aligned']/div")).Click();
        }
        
        [Given(@"I enter all the required details into certification")]
        public void GivenIEnterAllTheRequiredDetailsIntoCertification()
        {
            //Click on certificate textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationName']")).Click();

            //Add data into certificate textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationName']")).SendKeys("Graphics & Design");

            //Click on Certification From textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationFrom']")).Click();

            //Enter data in Certification from
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationFrom']")).SendKeys("Satyam");

            //click on year dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Select year
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("2012");
            
        }
        
        [When(@"I press Add button to add certification details")]
        public void WhenIPressAddButtonToAddCertificationDetails()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();
        }
        
        [Then(@"all the Certificate details should be displayed\.")]
        public void ThenAllTheCertificateDetailsShouldBeDisplayed_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a certificate");

                Thread.Sleep(1000);
                string ExpectedValue = "Graphics & Design has been added to your certification";
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certificate Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsAdded");
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
}//Add Certification
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Existing_Certification
    {
        [Given(@"I open the Webbrowser and login to the portal")]
        public void GivenIOpenTheWebbrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Certification  under profie tab and click on Add New")]
        public void GivenIClickOnCertificationUnderProfieTabAndClickOnAddNew()
        {
            //Click on Certification tab
            Driver.driver.FindElement(By.LinkText("Certifications")).Click();

            //Click on Add new
            Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div/div/table/thead/tr/th[@class='right aligned']/div")).Click();

        }

        [Given(@"I give all the fields with existing data\.")]
        public void GivenIGiveAllTheFieldsWithExistingData_()
        {
            //Click on certificate textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationName']")).Click();

            //Add data into certificate textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationName']")).SendKeys("Graphics & Design");

            //Click on Certification From textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationFrom']")).Click();

            //Enter data in Certification from
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationFrom']")).SendKeys("Satyam");

            //click on year dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Select year
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("2012");

        }

        [When(@"I click on Addbutton in certification")]
        public void WhenIClickOnAddbuttonInCertification()
        {
            // Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

        }

        [Then(@"it should dispaly an error message as ""(.*)""")]
        public void ThenItShouldDispalyAnErrorMessageAs(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a certificate");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Data already exists");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "ExistingData");
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
}//Existing Certification
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Null_Certification
    {
        [Given(@"I launch the Webbrowser and login to the portal")]
        public void GivenILaunchTheWebbrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Certification  under profile tab and Click on Add New")]
        public void GivenIClickOnCertificationUnderProfileTabAndClickOnAddNew()
        {
            // Click on Certification tab
            Driver.driver.FindElement(By.LinkText("Certifications")).Click();

            //Click on Add new
            Driver.driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div/div/table/thead/tr/th[@class='right aligned']/div")).Click();

        }

        [Given(@"I leave the fields empty")]
        public void GivenILeaveTheFieldsEmpty()
        {
            //Click on certificate textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationName']")).Click();

            //Add data into certificate textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationName']")).SendKeys("");

            //Click on Certification From textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationFrom']")).Click();

            //Enter data in Certification from
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='certificationFrom']")).SendKeys("Satyam");

            //click on year dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Select year
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("2012");

        }

        [When(@"I click on Addbutton")]
        public void WhenIClickOnAddbutton()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

        }

        [Then(@"it shows an error message as ""(.*)"" \.")]
        public void ThenItShowsAnErrorMessageAs_(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Adding Null values to certification");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Null values cannot be added");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "certificate_Null/");
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
}//NullCertification
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Delete_Certification
    {
        [Given(@"I launch  browser and login to the portal")]
        public void GivenILaunchBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Certification under profile tab and select the certification to delete")]
        public void GivenIClickOnCertificationUnderProfileTabAndSelectTheCertificationToDelete()
        {
            //Click on Certification tab
            Driver.driver.FindElement(By.LinkText("Certifications")).Click();

            //create list of data from table
            IList<IWebElement> listofCertificate = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr"));
            Console.WriteLine(listofCertificate.Count);

            foreach (var list in listofCertificate)
            {
                Console.WriteLine(list.Text);

                //select language to be deleted
                if (list.Text.Contains("Graphics & Design"))
                {
                    Thread.Sleep(1000);
                    //Click on delete icon
                    Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Graphics & Design')]//..//following-sibling::td[1]/span[2]/i")).Click();
                }
                else
                {

                    Console.WriteLine("Error");
                }


            }


        }

        [When(@"I click on  delete icon in certification")]
        public void WhenIClickOnDeleteIconInCertification()
        {

            //ScenarioContext.Current.Pending();
        }

        [Then(@"the deleted certification details should not be displayed and gives an error message\.")]
        public void ThenTheDeletedCertificationDetailsShouldNotBeDisplayedAndGivesAnErrorMessage_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a certificate");

                Thread.Sleep(1000);
                string ExpectedValue = "Graphics & Design has been deleted from your certification";
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certificate Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsAdded");
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
}//delete certification

