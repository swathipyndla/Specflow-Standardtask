using NUnit.Framework;
using OpenQA.Selenium;
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
    public class SpecFlowFeature1Steps : Utils.Start
    {
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();
            Driver.driver.FindElement(By.LinkText("Languages")).Click();



        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {

            //Click on Add New button
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//th[@class='right aligned']/div")).Click();
            Thread.Sleep(4000);
            //Add Language
            Driver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();

            //Choose the language level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[@value = 'Basic']")).Click();
           


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

        }
        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English has been added to your languages";
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if(ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
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
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Adding_multiple_lang
    {
        [Given(@"I  click on the Language tab under Profile page")]
        public void GivenIClickOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

        }

        [When(@"I add new '(.*)' and  add level")]
        public void WhenIAddNewAndAddLevel(string p0)
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//th[@class='right aligned']/div")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys(p0);


            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
            Thread.Sleep(1000);

            //Choose the language level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[@value = 'Basic']")).Click();


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

            try
            {
                //Start the Reports

                //string text = "  has been added to your languages";
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(2000);
                string ExpectedValue = p0 + " has been added to your languages";

                Thread.Sleep(1000);
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(2000);
               if(ExpectedValue==ActualValue)
                { 
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }
                else
                {

                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }




        }

    


        [Then(@"all the languages with language level should be displayed on my listings")]
        public void ThenAllTheLanguagesWithLanguageLevelShouldBeDisplayedOnMyListings()
        {
           //

        }

    }
}
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Update_language
    {
        [Given(@"I click on the Language  tab under Profile page")]
        public void GivenIClickOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();


        }

        [When(@"I click on edit")]
        public void WhenIClickOnEdit()
        {
            //select the lang to edit
            string[] lang = { "English", "Telugu", "Hindi", "Tamil" };
            for (int i = 0; i < 4; i++)
            {
                if (lang[i] == "Telugu")
                {
                    Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Telugu')]//..//following-sibling::td[1]/span[1]/i")).Click();

                }
                else
                {
                    Console.WriteLine("error");
                }

            }
        }

        [When(@"I add a new language and click on update")]
        public void WhenIAddANewLanguageAndClickOnUpdate()
        {
            Thread.Sleep(1500);
            //click on the text to update
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @value='Telugu']")).Click();
            Thread.Sleep(1000);
            //clear the existing data
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @value='Telugu'] ")).Clear();
            //update new value
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @value='Telugu']")).SendKeys("Tamil");
            Thread.Sleep(1000);
            // click on lang level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[@value='Basic']")).Click();
            //select lang
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[@value='Fluent']")).Click();
            //click on update
            Driver.driver.FindElement(By.XPath("//input[@type='button']")).Click();

        }

        [Then(@"updated language should be displayed on my listings")]
        public void ThenUpdatedLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "Tamil";
                string ActualValue = Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'Tamil')]")).Text;
                Thread.Sleep(1000);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed,Updated a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
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
    namespace SpecflowTests.AcceptanceTest
    {
        [Binding]
        public class Cancel_Update_Operation
        {
            [Given(@"I  click on  the Language  tab under Profile page")]
            public void GivenIClickOnTheLanguageTabUnderProfilePage()
            {
                //Wait
                Thread.Sleep(1500);

                // Click on Profile tab
                Driver.driver.FindElement(By.LinkText("Profile")).Click();
            }

            [When(@"I click on edit and click on cancel")]
            public void WhenIClickOnEditAndClickOnCancel()
            {
                Thread.Sleep(1500);
                string[] lang = { "English", "Telugu", "Hindi", "Tamil" };
                for (int i = 0; i < 4; i++)
                {
                    if (lang[i] == "English")
                    {
                        //select the lang to edit
                        Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'English')]//..//following-sibling::td[1]/span[1]/i")).Click();


                        //click on cancel
                        Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']")).Click();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
            }
            [Then(@"the update operation should be cancelled")]
            public void ThenTheUpdateOperationShouldBeCancelled()
            {
                try
                {
                    //Start the Reports
                    CommonMethods.ExtentReports();
                    Thread.Sleep(1000);
                    CommonMethods.test = CommonMethods.extent.StartTest(" Cancel update operation");

                    Thread.Sleep(1000);
                    string ExpectedValue = "English";
                    string ActualValue = Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'English')]")).Text;
                    Thread.Sleep(1500);
                    if (ExpectedValue == ActualValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Cancelled an operation successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language cancelled");
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


    namespace SpecflowTests.AcceptanceTest
    {
        [Binding]
        public class Delete_language
        {
            [Given(@"I  click on the Language  tab under Profile page")]
            public void GivenIClickOnTheLanguageTabUnderProfilePage()
            {
                //Wait
                Thread.Sleep(1500);

                // Click on Profile tab
                Driver.driver.FindElement(By.LinkText("Profile")).Click();


            }

            [When(@"I click on delete")]
            public void WhenIClickOnDelete()
            {                                                                           //table[@class='ui fixed table']/tbody/tr/td[1]
                                                                                        //create a list of options
               //create list of data from table
                IList<IWebElement> listoflang = Driver.driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr"));
                Console.WriteLine(listoflang.Count);
               
                foreach (var list in listoflang)
                {
                    Console.WriteLine(list.Text);

                    //select language to be deleted

                    if (list.Text.Contains("English"))
                    {
                        Thread.Sleep(3000);
                        //delete lang
                        Driver.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(),'English')]//..//following-sibling::td[1]/span[2]/i")).Click();
                    }
                    else
                    {

                        Console.WriteLine("Error");
                    }

                    
                }

            }

            


            [Then(@"the deleted language should not be displayed on my listings")]
            public void ThenTheDeletedLanguageShouldNotBeDisplayedOnMyListings()
            {
                try
                {
                    //Start the Reports
                    CommonMethods.ExtentReports();
                    Thread.Sleep(1000);
                    CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");

                    Thread.Sleep(1000);
                    string ExpectedValue = "English has been deleted from your languages";
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

    }
    namespace SpecflowTests.AcceptanceTest
    {
        [Binding]
        public class Adding_Null_Values
        {
            [Given(@"I  click on the Language tab  under Profile page")]
            public void GivenIClickOnTheLanguageTabUnderProfilePage()
            {
                // Wait
                Thread.Sleep(2000);

                // Click on Profile tab
                Driver.driver.FindElement(By.LinkText("Profile")).Click();
                Driver.driver.FindElement(By.LinkText("Languages")).Click();


            }

            [When(@"I click on Add language")]
            public void WhenIClickOnAddLanguage()
            {
                //Click on Add New button
                Thread.Sleep(2000);
                Driver.driver.FindElement(By.XPath("//th[@class='right aligned']/div")).Click();

            }

            [When(@"I leave the text box empty for language or don't choose any language level")]
            public void WhenILeaveTheTextBoxEmptyForLanguageOrDonTChooseAnyLanguageLevel()
            {
                Thread.Sleep(4000);
                //Add Language
                Driver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("");

                //Click on Language Level
                Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();

                //Choose the language level
                Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[@value = 'Basic']")).Click();



                //Click on Add button
                Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();
            }

            [Then(@"it should throw an errror as please enter language and level\.")]
            public void ThenItShouldThrowAnErrrorAsPleaseEnterLanguageAndLevel_()
            {
                try
                {
                    //Start the Reports
                    CommonMethods.ExtentReports();
                    Thread.Sleep(1000);
                    CommonMethods.test = CommonMethods.extent.StartTest("Add Null value");

                    Thread.Sleep(1000);
                    string ExpectedValue = "Please enter language and level";
                    string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                    Thread.Sleep(500);
                    if (ExpectedValue == ActualValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Null values");
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

}