using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Reference chrome driver
            IWebDriver driver = new ChromeDriver(@"/Users/ephraimkgwele/Desktop/csharp/automation/automationTest/automationTest/");

            //Go to Instagram
            driver.Navigate().GoToUrl("https://instagram.com");

            //Find the login with facebook botton and click it
            IWebElement fb_login_btn = driver.FindElement(By.ClassName("sqdOP"));
            fb_login_btn.Click();

            //Find the email and password fields
            IWebElement email_input = driver.FindElement(By.Id("email"));
            IWebElement pass_input = driver.FindElement(By.Id("pass"));
            IWebElement cnt_submit = driver.FindElement(By.Id("loginbutton"));

            //Fill in your login details to login
            //For the script to be able to login you need to supply your login details
            email_input.SendKeys("YOUR FACEBOOK EMAIL HERE");
            pass_input.SendKeys("YOUR FACEBOOK PASSWORD HERE");

            //Submit login form
            cnt_submit.Click();

            //Wait for page to load everything
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Click not now on the instagram pop up
            IWebElement notNow = driver.FindElement(By.ClassName("HoLwm"));
            notNow.Click();

            //Find the search box
            IWebElement search_input = driver.FindElement(By.ClassName("x3qfX"));

            //Enter my name in the search box
            search_input.SendKeys("ephraim kgwele");

            //Wait for search results to load
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Follow link to my profile
            IWebElement link = driver.FindElement(By.XPath("//div[@class='fuqBx']/a[@href='/if_rhymes/']"));
            link.Click();

            //Click the follow button on my profile
            IWebElement follow_btn = driver.FindElement(By.XPath("//button[@text()='Follow Back']"));
            follow_btn.Click();

            //Open first post
            IWebElement post_1 = driver.FindElement(By.XPath("//a[@href='/p/BupNhJ9g494/']"));
            post_1.Click();

            //Find and Save all posts to a list
            var allThePosts = driver.FindElements(By.ClassName("v1Nh3"));

            //Loop though all the posts
            foreach (var onePost in allThePosts)
            {
                //Wait for the post to load
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                //Like the post
                IWebElement like_post = driver.FindElement(By.XPath("//span[@class='fr66n']"));
                like_post.Click();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                //Go to next post
                IWebElement next_post = driver.FindElement(By.ClassName("coreSpriteRightPaginationArrow"));
                next_post.Click();

            } //Repeat Task 




        }
    }
}
