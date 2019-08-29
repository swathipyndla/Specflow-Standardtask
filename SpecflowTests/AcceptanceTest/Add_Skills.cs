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
    public class Add_Skills
    {
        [Given(@"I am  able to launch the browser and login to the dashboard")]
        public void GivenIAmAbleToLaunchTheBrowserAndLoginToTheDashboard()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

           
        }

        [Given(@"I click on Skills_tab under profile page and click on Add new")]
        public void GivenIClickOnSkills_TabUnderProfilePageAndClickOnAddNew()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.LinkText("Skills")).Click();

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

        }

        [Given(@"enter some text into the skills Textbox and choose the level of skills")]
        public void GivenEnterSomeTextIntoTheSkillsTextboxAndChooseTheLevelOfSkills()
        {
            //Entering skills into skills text box
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).Click();

            //Enter skills name
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).SendKeys("C#");

            //Click on skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Select Skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("Intermediate");

            
        }

        [When(@"I press Add button")]
        public void WhenIPressAddButton()
        {
            //Click on Add
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

        }

        [Then(@"skill with its level should be added and displayed\.")]
        public void ThenSkillWithItsLevelShouldBeAddedAndDisplayed_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "C# has been added to your skills";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
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
} //Add Skills
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Add_Existing_Data
    {
        [Given(@"I  launch the browser and login to the portal")]
        public void GivenILaunchTheBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Skills tab  under profile page")]
        public void GivenIClickOnSkillsTabUnderProfilePage()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.LinkText("Skills")).Click();

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

        }

        [Given(@"I enter existing skills with same level")]
        public void GivenIEnterExistingSkillsWithSameLevel()
        {
            //Entering skills into skills text box
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).Click();

            //Enter skills name
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).SendKeys("C#");

            //Click on skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Select Skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("Intermediate");

        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            //Click on Add
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

        }

        [Then(@"it should display an error message as ""(.*)""\.")]
        public void ThenItShouldDisplayAnErrorMessageAs_(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "This skill is already exist in your skill list.";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
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
} //Existing data
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Adding_MultipleSkills
    {


        [Given(@"I am able to launch the browser and login to the portal")]
        public void GivenIAmAbleToLaunchTheBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Skills tab under profile page and click on Add new")]
        public void GivenIClickOnSkillsTabUnderProfilePageAndClickOnAddNew()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.LinkText("Skills")).Click();

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

        }

        [Given(@"enter '(.*)' into the skills and choose the level of skills")]
        public void GivenEnterIntoTheSkillsAndChooseTheLevelOfSkills(string p0)
        {

            //Entering skills into skills text box
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).Click();

            //Enter skills name
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).SendKeys(p0);

            //Click on skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Select Skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("Intermediate");

            //Click on Add
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

            //Validating the result
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = p0 + " has been added to your skills";
                Console.WriteLine("Expected value is" + ExpectedValue);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
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

        [When(@"I press Add")]
        public void WhenIPressAdd()
        {

            //

        }

        [Then(@"skills with its level should be added and dispalyed\.")]
        public void ThenSkillsWithItsLevelShouldBeAddedAndDispalyed_()
        {

        }
    }
} //Adding Multiple skills
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Adding_NullValues
    {
        [Given(@"Iam able to launch browser and login to the portal")]
        public void GivenIamAbleToLaunchBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Skills tab under profile page\.")]
        public void GivenIClickOnSkillsTabUnderProfilePage_()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.LinkText("Skills")).Click();

            //Click on Add new button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

        }

        [Given(@"I click on Add new and leave the skills tab or skills level tab empty")]
        public void GivenIClickOnAddNewAndLeaveTheSkillsTabOrSkillsLevelTabEmpty()
        {
            //Entering skills into skills text box
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).Click();

            //Enter skills name
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).SendKeys("");

            //Click on skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Select Skills level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("Intermediate");

        }

        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            //Click on Add
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

        }

        [Then(@"it should throw an error message as ""(.*)""\.")]
        public void ThenItShouldThrowAnErrorMessageAs_(string p0)
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
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Null values cannot be added");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Null values are not accepted");
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
}//Adding null values
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Duplicated_Data
    {
        public object SelectElement { get; private set; }

        [Given(@"I  click on the  Skills  tab under Profile page")]
        public void GivenIClickOnTheSkillsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [When(@"I try to add the existing Skills with different language level")]
        public void WhenITryToAddTheExistingSkillsWithDifferentLanguageLevel()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.LinkText("Skills")).Click();

            //create list of skills data from table
            IList<IWebElement> listofSkills = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr"));
            Console.WriteLine(listofSkills.Count);

            foreach (var list in listofSkills)
            {
                Console.WriteLine(list.Text);

                //select a skill that already exists
                if (list.Text.Contains("C#"))
                {
                    Thread.Sleep(1000);

                    //Click on Add new
                    Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

                    //Entering skills into skills text box
                    Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).Click();

                    //Enter skills name
                    Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).SendKeys("C#");

                    //Select level of the skills
                    Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).SendKeys("Expert");

                    //Click on add button
                    Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();
                }


            }


        }

        [Then(@"it should throw an error as ""(.*)""\.")]
        public void ThenItShouldThrowAnErrorAs_(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add an existing Skill");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Data cannot be duplicated");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skills cannot be duplicated");
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
}//Duplicate data
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Delete_Skill
    {
        [Given(@"I am  able to launch the browser and login to the portal")]
        public void GivenIAmAbleToLaunchTheBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Skills tab under profile page")]
        public void GivenIClickOnSkillsTabUnderProfilePage()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.LinkText("Skills")).Click();

        }

        [Given(@"I choose a language to delete")]
        public void GivenIChooseALanguageToDelete()
        {
            //create list of data from table
            IList<IWebElement> listofSkills = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr"));
            Console.WriteLine(listofSkills.Count);

            foreach (var list in listofSkills)
            {
                Console.WriteLine(list.Text);

                //select language to be deleted

                if (list.Text.Contains("C#"))
                {
                    Thread.Sleep(1000);
                    //Click on delete icon
                    Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'C#')]//..//following-sibling::td[1]/span[2]/i")).Click();
                }
                else
                {

                    Console.WriteLine("Error");
                }


            }

        }

        [When(@"I click on  delete")]
        public void WhenIClickOnDelete()
        {
            //
        }

        [Then(@"skills with its level should be deleted\.")]
        public void ThenSkillsWithItsLevelShouldBeDeleted_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "C# has been deleted";
                Thread.Sleep(3000);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
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
}//Deleting skills.
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Update_Skills
    {
        [Given(@"Iam able to launch the browser and login to the portal")]
        public void GivenIamAbleToLaunchTheBrowserAndLoginToThePortal()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [Given(@"I click on Skills tab")]
        public void GivenIClickOnSkillsTab()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.LinkText("Skills")).Click();

        }

        [Given(@"I choose a language to update and click on edit")]
        public void GivenIChooseALanguageToUpdateAndClickOnEdit()
        {
            //create list of data from table
            IList<IWebElement> listofSkills = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr"));
            Console.WriteLine(listofSkills.Count);

            foreach (var list in listofSkills)
            {
                Console.WriteLine(list.Text);

                //select language to be deleted

                if (list.Text.Contains("C#"))
                {
                    Thread.Sleep(1000);
                    //Click on delete icon
                    Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'C#')]//..//following-sibling::td[1]/span[1]/i")).Click();
                }
                else
                {

                    Console.WriteLine("Error");
                }


            }

        }

        [Given(@"I clear the existing data and enter new one and choose the level")]
        public void GivenIClearTheExistingDataAndEnterNewOneAndChooseTheLevel()
        {
            Thread.Sleep(1500);
            //click on the text to update
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @value='C#']")).Click();

            Thread.Sleep(1000);
            //clear the existing data
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @value='C#'] ")).Clear();

            //update with new skill
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @value='C#']")).SendKeys(".Net");
            Thread.Sleep(1000);

            // click on Skill level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']/option[@value='Intermediate']")).Click();

            //select new level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']/option[@value='Expert']")).Click();


        }

        [When(@"I click on update")]
        public void WhenIClickOnUpdate()
        {
            //click on update
            Driver.driver.FindElement(By.XPath("//input[@type='button']")).Click();

        }

        [Then(@"updated skills with its level should be added and displayed\.")]
        public void ThenUpdatedSkillsWithItsLevelShouldBeAddedAndDisplayed_()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = ".Net";
                string ActualValue = Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'.Net')]")).Text;
                Thread.Sleep(1000);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Updated a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Skill updated");
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
}//Update skills





