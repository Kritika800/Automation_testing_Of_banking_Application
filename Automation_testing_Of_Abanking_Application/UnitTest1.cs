using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation_testing_Of_banking_Application
{
    public class Tests
    {
        public WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            //registration
            driver.Navigate().GoToUrl("https://github.com/Kritika800/ASP.NET_MVC_based_banking_application/blob/master/Bank%20Management%20System/Views/Bank_Account_Registration/Create.cshtml");
            driver.FindElement(By.Id("type1")).Click();
            driver.FindElement(By.Id("Confirm_Type_Of_Bank_ACCOUNT")).SendKeys("Personal Savings");
            driver.FindElement(By.XPath("/html/body/div/form/div/div[2]/select/option[3]")).SendKeys("Personal Savings");
            driver.FindElement(By.Id("Confrim_Type_Of_CURRENCY")).SendKeys("INR");
            driver.FindElement(By.Id("First_Name")).SendKeys("Sita");
            driver.FindElement(By.Id("Last_Name")).SendKeys("Ram");
            driver.FindElement(By.Name("Contact_Number")).SendKeys("7467284");
            driver.FindElement(By.Name("Email_Address")).SendKeys("Sita.Ram19@gmail.com");
            driver.FindElement(By.Id("Mailing_Home_Address")).SendKeys("Ayodhya,Uttar Pradesh");
            driver.FindElement(By.Id("City")).SendKeys("Ayodhya");
            driver.FindElement(By.Id("State")).SendKeys("UP");

            driver.FindElement(By.Id("Postal_Code")).SendKeys("67238");

            driver.FindElement(By.XPath("/html/body/div/form/div/div[12]/div/input")).SendKeys("INDIA");
            driver.FindElement(By.ClassName("btn btn-success")).Click();

        //bank authorization


        driver.Navigate().GoToUrl("https://localhost:44338/BankAuthorizationForm/Create");
            driver.FindElement(By.Id("City")).SendKeys("Ayodhya");
            driver.FindElement(By.Id("Firstname")).SendKeys("Sita");
            driver.FindElement(By.Id("Lastname")).SendKeys("Ram");
            driver.FindElement(By.Id("EmailId")).SendKeys("Sita.Ram19@gmail.com");
            driver.FindElement(By.Id("Phone_No")).SendKeys("637829293");
            driver.FindElement(By.Name("BankName")).SendKeys("Canara Bank");
            driver.FindElement(By.Id("BankBranch")).SendKeys("Ayodhya");
            driver.FindElement(By.Id("BankPhonenumber")).SendKeys("5789834200");
            driver.FindElement(By.XPath("/html/body/div/form/div/input[1]")).Click();
            driver.FindElement(By.Id("Confirm_bank_Account_Type")).SendKeys("Personal checking ");

            driver.FindElement(By.Name("Agreement")).Click();
            driver.FindElement(By.Id("Signature")).SendKeys("SITA");
            driver.FindElement(By.Name("Agreement2")).Click();
            driver.FindElement(By.ClassName("btn btn-success")).Click();



            //bank credit request

            //driver.Navigate().GoToUrl("driver.Navigate().GoToUrl("https://localhost:44338/BankAuthorizationForm/Create");
            driver.FindElement(By.Id("Parent_Name")).SendKeys("Raja Janak");
            driver.FindElement(By.Id("PermanentAddress_Line1")).SendKeys("Ayodhya");
            driver.FindElement(By.Id("PermanentAddress_Line2")).SendKeys("UP");
            driver.FindElement(By.Id("City")).SendKeys("Ayodhya");
            driver.FindElement(By.Id("Region")).SendKeys("North");
            driver.FindElement(By.Name("PostalCode")).SendKeys("362738");
            driver.FindElement(By.Id("Country")).SendKeys("India");
            driver.FindElement(By.Id("Contact_Number")).SendKeys("6748748329");
            driver.FindElement(By.Id("First_Participant_Name")).SendKeys("Sita");

            driver.FindElement(By.Name("DateOfBirth")).SendKeys("12-9-1788");
            driver.FindElement(By.XPath("/html/body/div/center/form/div/div[12]/div/input")).Click();
            driver.FindElement(By.Name("Class_Code")).SendKeys("General");
            driver.FindElement(By.XPath("/html/body/div/center/form/div/div[14]/div/input")).SendKeys("5-9-2000");
            driver.FindElement(By.XPath("/html/body/div/center/form/div/div[15]/div/input")).SendKeys("1000");
            driver.FindElement(By.Id("Reason_For_CreditRequest")).SendKeys("Medical Purpose");

            driver.FindElement(By.Name("Agreement")).Click();
            driver.FindElement(By.Id("Signature")).SendKeys("SITA");
            driver.FindElement(By.Name("Agreement2")).Click();
            driver.FindElement(By.ClassName("btn btn-success")).Click();



        Assert.Pass();

        //bank authorization


       
        }
    }
}