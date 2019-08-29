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
    public class Education_Add
    {
        [Given(@"I launched the browser and login to the portal")]
        public void GivenILaunchedTheBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Education tab  under profile tab and click on Add New")]
        public void GivenIClickOnEducationTabUnderProfileTabAndClickOnAddNew()
        {
            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//div[@data-tab='third']/div/div/div/table/thead/tr/th[@class='right aligned']/div")).Click();

        }

        [Given(@"I enter all the required details in education tab")]
        public void GivenIEnterAllTheRequiredDetailsInEducationTab()
        {
            //Click on College name textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='instituteName']")).Click();

            //Enter college name
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='instituteName']")).SendKeys("RSHS");

            //Click on Country dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='country']")).Click();

            //Select country

            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='country']")).SendKeys("India");

            //Click on Title
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='title']")).Click();

            //Select title
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='title']")).SendKeys("M.B.A");

            //Click on Degree
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='degree']")).Click();

            //Enter Degree
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='degree']")).SendKeys("Masters of Bussiness Administration");

            //Click on year dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='yearOfGraduation']")).Click();

            //Select year
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='yearOfGraduation']")).SendKeys("2010");

        }

        [When(@"I press Add button to add Education")]
        public void WhenIPressAddButtonToAddEducation()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button ' and @value='Add']")).Click();

        }

        [Then(@"all the  Education data should be displayed\.")]
        public void ThenAllTheEducationDataShouldBeDisplayed_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add an Education");

                Thread.Sleep(1000);
                string ExpectedValue = "Education has been added";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
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
}//Add Education
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Education_Duplication
    {
        [Given(@"I launch the browser and login to  portal")]
        public void GivenILaunchTheBrowserAndLoginToPortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Education  under profie tab and click on Add New")]
        public void GivenIClickOnEducationUnderProfieTabAndClickOnAddNew()
        {
            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//div[@data-tab='third']/div/div/div/table/thead/tr/th[@class='right aligned']/div")).Click();

        }

        [Given(@"I give all the fields with existing data and give different value for year\.")]
        public void GivenIGiveAllTheFieldsWithExistingDataAndGiveDifferentValueForYear_()
        {
            //Click on College name textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='instituteName']")).Click();

            //Enter college name
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='instituteName']")).SendKeys("RSHS");

            //Click on Country dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='country']")).Click();

            //Select country

            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='country']")).SendKeys("India");

            //Click on Title
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='title']")).Click();

            //Select title
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='title']")).SendKeys("M.B.A");

            //Click on Degree
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='degree']")).Click();

            //Enter Degree
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='degree']")).SendKeys("Masters of Bussiness Administration");

            //Click on year dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='yearOfGraduation']")).Click();

            //Select year
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='yearOfGraduation']")).SendKeys("2012");


        }

        [When(@"I click on Add Button")]
        public void WhenIClickOnAddButton()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button ' and @value='Add']")).Click();

        }

        [Then(@"it should dispaly an error message as ""(.*)""\.")]
        public void ThenItShouldDispalyAnErrorMessageAs_(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("duplicate Education");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Duplication not occured");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education_Duplication");
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
}//Duplicate Education
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Education_NullVal
    {
        [Given(@"I launched browser and login to the portal")]
        public void GivenILaunchedBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Education  under profile tab and Click on Add New")]
        public void GivenIClickOnEducationUnderProfileTabAndClickOnAddNew()
        {
            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//div[@data-tab='third']/div/div/div/table/thead/tr/th[@class='right aligned']/div")).Click();

        }

        [Given(@"I leave the fields empty in education tab")]
        public void GivenILeaveTheFieldsEmptyInEducationTab()
        {
            //Click on College name textbox
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='instituteName']")).Click();

            //Enter college name
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='instituteName']")).SendKeys("");

            //Click on Country dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='country']")).Click();

            //Select country
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='country']")).SendKeys("India");

            //Click on Title
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='title']")).Click();

            //Select title
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='title']")).SendKeys("M.B.A");

            //Click on Degree
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='degree']")).Click();

            //Enter Degree
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='degree']")).SendKeys("Masters of Bussiness Administration");

            //Click on year dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='yearOfGraduation']")).Click();

            //Select year
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='yearOfGraduation']")).SendKeys("2010");



        }

        [When(@"I click on Add button in education tab")]
        public void WhenIClickOnAddButtonInEducationTab()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button ' and @value='Add']")).Click();

        }

        [Then(@"it shows an error message as ""(.*)""")]
        public void ThenItShowsAnErrorMessageAs(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Null values cannot be added");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Null values cannot be added");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Null_Education");
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
}//NullEducation
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Education_Delete
    {
        [Given(@"I launch the browser and login to the portal")]
        public void GivenILaunchTheBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Education  under profile tab and select the education to delete")]
        public void GivenIClickOnEducationUnderProfileTabAndSelectTheEducationToDelete()
        {
            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("//a[@data-tab='third']")).Click();

            //create list of data from table
            IList<IWebElement> listofEducation = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr"));
            Console.WriteLine(listofEducation.Count);

            foreach (var list in listofEducation)
            {
                Console.WriteLine(list.Text);

                //select language to be deleted
                if (list.Text.Contains("RSHS"))
                {
                    Thread.Sleep(1000);
                    //Click on delete icon
                    Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'RSHS')]//..//following-sibling::td[1]/span[2]/i")).Click();
                }
                else
                {

                    Console.WriteLine("Error");
                }


            }


        }

        [When(@"I click on delete icon in education")]
        public void WhenIClickOnDeleteIconInEducation()
        {
            //  ScenarioContext.Current.Pending();
        }

        [Then(@"the deleted education details should not be displayed and gives a message as ""(.*)""\.")]
        public void ThenTheDeletedEducationDetailsShouldNotBeDisplayedAndGivesAMessageAs_(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a certificate");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted education successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Deleted");
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
}//Delete Education


