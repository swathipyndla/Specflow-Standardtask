using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Add_ShareSkill
    {
        [Given(@"I have launched browser and click on profile and click on shareskill button")]
        public void GivenIHaveLaunchedBrowserAndClickOnProfileAndClickOnShareskillButton()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

            //Click on shareskill
            Driver.driver.FindElement(By.XPath("//a[@class='ui basic green button']")).Click();
        }

        [Given(@"I have entered all the required fields")]
        public void GivenIHaveEnteredAllTheRequiredFields()
        {
            
            //Click on title
            Driver.driver.FindElement(By.XPath("//input[@type='text'  and @name='title']")).Click();

            //Enter title
            Driver.driver.FindElement(By.XPath("//input[@type='text'  and @name='title']")).SendKeys("selenium");

            //Click on desciption
            Driver.driver.FindElement(By.XPath("//textarea[@name='description']")).Click();

            //Enter desciption
            Driver.driver.FindElement(By.XPath("//textarea[@name='description']")).SendKeys("This describes about selenium concepts");

            //Click on category
             Driver.driver.FindElement(By.XPath("//select[@name='categoryId']")).Click();

            //Select category
            SelectElement cat_opt = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='categoryId']")));
            cat_opt.SelectByIndex(6);
            
            //Click on Subcategory
            Driver.driver.FindElement(By.XPath("//select[@name='subcategoryId']")).Click();

            //Select Subcategory
            SelectElement Subcat_opt = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='subcategoryId']")));
            Subcat_opt.SelectByIndex(5);

            //Click on tags
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper field  ']/div[@class='ReactTags__tags']/div/div/input")).Click();
            
            //Click on tags
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper field  ']/div[@class='ReactTags__tags']/div/div/input")).SendKeys("C#");

           
            //enter  tags
           IWebElement tags= Driver.driver.FindElement(By.XPath("//div[@class='ReactTags__tagInput']/input")); ;
            tags.SendKeys(Keys.Enter);

            //Click on next tag
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper field  ']/div[@class='ReactTags__tags']/div/div/input")).Click();

            //enter  tags
            Driver.driver.FindElement(By.XPath("//div[@class='ReactTags__tagInput']/input")).SendKeys("java");

            tags.SendKeys(Keys.Enter);

            //Click on servicetype
            Driver.driver.FindElement(By.XPath("//input[@name='serviceType' and @value='1']")).Click();

            //Click on locationtype
            Driver.driver.FindElement(By.XPath("//input[@name='locationType' and @value='1']")).Click();

            //Enter  startdate
            Driver.driver.FindElement(By.XPath("//input[@name='startDate']")).Click();
            Driver.driver.FindElement(By.XPath("//input[@name='startDate']")).SendKeys("02-05-1989");

            //Enter enddate
            Driver.driver.FindElement(By.XPath("//input[@name='endDate']")).Click();
            Driver.driver.FindElement(By.XPath("//input[@name='endDate']")).SendKeys("02-10-2020");

            //Select skills trade
            Driver.driver.FindElement(By.XPath("//div[1]/div/input[@name='skillTrades' and @type='radio']")).Click();
           
            //click on skill exchange
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']/div[@class='ReactTags__tags']/div/div/input")).Click();


            //Add tags in skill exchange
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']/div[@class='ReactTags__tags']/div/div/input")).SendKeys("sap");

            //click on skill exchange
           IWebElement Skills= Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']/div[@class='ReactTags__tags']/div/div/input"));
            Skills.SendKeys(Keys.Enter);

            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']/div[@class='ReactTags__tags']/div/div/input")).Click();
            
            //Add tags in skill exchange
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']/div[@class='ReactTags__tags']/div/div/input")).SendKeys("Jmeter");

            Skills.SendKeys(Keys.Enter);
            //Click on Active
            Driver.driver.FindElement(By.XPath("//div[1]/div/input[@name='isActive']")).Click();

        }

        [When(@"I Click on save button")]
        public void WhenIClickOnSaveButton()
        {
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Save']")).Click();
        }
        
        [Then(@"the result should give a message as ""(.*)""")]
        public void ThenTheResultShouldGiveAMessageAs(string p0)
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
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Service listing saved Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Service listing saved");
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
}//Add shareskill
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class ShareSkill_Splchar
    {
        [Given(@"I launch the browser and click on profile and click on shareskill button")]
        public void GivenILaunchTheBrowserAndClickOnProfileAndClickOnShareskillButton()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

            //Click on shareskill
            Driver.driver.FindElement(By.XPath("//a[@class='ui basic green button']")).Click();

        }

        [When(@"I Click on title and enter special charecter")]
        public void WhenIClickOnTitleAndEnterSpecialCharecter()
        {
            //Click on title
            Driver.driver.FindElement(By.XPath("//input[@type='text'  and @name='title']")).Click();

            //Enter title
            Driver.driver.FindElement(By.XPath("//input[@type='text'  and @name='title']")).SendKeys("@selenium");

        }

        [Then(@"the result should give message as ""(.*)""")]
        public void ThenTheResultShouldGiveMessageAs(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ui basic red prompt label transition visible']")).Text;
                Console.WriteLine(ActualValue);
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Service listing saved Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Service listing saved");
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
}//Special character in title
namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class ShareSkill_Nullval
    {
        [Given(@"I launch browser and click on profile and click on shareskill button")]
        public void GivenILaunchBrowserAndClickOnProfileAndClickOnShareskillButton()
        {
            //Wait
            Thread.Sleep(2000);

            // Click on Profile tab
            Driver.driver.FindElement(By.LinkText("Profile")).Click();

            //Click on shareskill
            Driver.driver.FindElement(By.XPath("//a[@class='ui basic green button']")).Click();

        }

        [Given(@"I have given null values in the required fields")]
        public void GivenIHaveGivenNullValuesInTheRequiredFields()
        {
            //Click on title
            Driver.driver.FindElement(By.XPath("//input[@type='text'  and @name='title']")).Click();

            //Enter title
            Driver.driver.FindElement(By.XPath("//input[@type='text'  and @name='title']")).SendKeys("selenium");

            //Click on desciption
            Driver.driver.FindElement(By.XPath("//textarea[@name='description']")).Click();

            //Enter desciption
            Driver.driver.FindElement(By.XPath("//textarea[@name='description']")).SendKeys("This describes about selenium concepts");

            //Click on category
            Driver.driver.FindElement(By.XPath("//select[@name='categoryId']")).Click();

            //Select category
            SelectElement cat_opt = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='categoryId']")));
            cat_opt.SelectByIndex(6);

            //Click on Subcategory
            Driver.driver.FindElement(By.XPath("//select[@name='subcategoryId']")).Click();

            //Select Subcategory
            SelectElement Subcat_opt = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='subcategoryId']")));
            Subcat_opt.SelectByIndex(5);

            //Click on tags
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper field  ']/div[@class='ReactTags__tags']/div/div/input")).Click();

            //Click on tags
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper field  ']/div[@class='ReactTags__tags']/div/div/input")).SendKeys("C#");


            //enter  tags
            IWebElement tags = Driver.driver.FindElement(By.XPath("//div[@class='ReactTags__tagInput']/input")); ;
            tags.SendKeys(Keys.Enter);

            //Click on next tag
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper field  ']/div[@class='ReactTags__tags']/div/div/input")).Click();

            //enter  tags
            Driver.driver.FindElement(By.XPath("//div[@class='ReactTags__tagInput']/input")).SendKeys("java");

            tags.SendKeys(Keys.Enter);

            //Click on servicetype
            Driver.driver.FindElement(By.XPath("//input[@name='serviceType' and @value='1']")).Click();

            //Click on locationtype
            Driver.driver.FindElement(By.XPath("//input[@name='locationType' and @value='1']")).Click();

            //Enter  startdate
            Driver.driver.FindElement(By.XPath("//input[@name='startDate']")).Click();
            Driver.driver.FindElement(By.XPath("//input[@name='startDate']")).SendKeys("02-05-1989");

            //Enter enddate
            Driver.driver.FindElement(By.XPath("//input[@name='endDate']")).Click();
            Driver.driver.FindElement(By.XPath("//input[@name='endDate']")).SendKeys("02-10-2020");

            //Select skills trade
            Driver.driver.FindElement(By.XPath("//div[1]/div/input[@name='skillTrades' and @type='radio']")).Click();

            //click on skill exchange
            Driver.driver.FindElement(By.XPath("//div[@class='form-wrapper']/div[@class='ReactTags__tags']/div/div/input")).Click();



        }

        [When(@"I Click on save button\.")]
        public void WhenIClickOnSaveButton_()
        {
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Save']")).Click();

        }

        [Then(@"the result should give  message as ""(.*)""")]
        public void ThenTheResultShouldGiveMessageAs(string p0)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Null values to add in share skill");

                Thread.Sleep(1000);
                string ExpectedValue = p0;
                string ActualValue = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Service listing not saved");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Service listing not saved");
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
} //Null values in shareskill


