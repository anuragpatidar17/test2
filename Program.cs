using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {

            var driver = new ChromeDriver();

            

                driver.Navigate().GoToUrl("http://www.google.com/");


                IWebElement query = driver.FindElement(By.Name("q"));


            Console.WriteLine(driver.Title + " Checking");

                
                query.Submit();



                driver.Quit();
            




        }
    }
}
