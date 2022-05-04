using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [TestFixture]
    public class Amazon
    {
        [Test]
        public void GetGridsInfo()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Url = "https://www.amazon.in/";
                driver.Manage().Window.Maximize();

                IReadOnlyList<IWebElement> grids = driver.FindElements(By.XPath("//*[starts-with(@id,'desktop-grid')]"));
                Console.WriteLine($"Grids available {grids.Count}");
                for (int i = 1; i <= grids.Count; i++)
                {
                    Console.WriteLine(driver.FindElement(By.XPath($"//*[@id='desktop-grid-{i}']/descendant::h2")).Text);
                }

                IReadOnlyList<IWebElement> btfgrids = driver.FindElements(By.XPath("//*[starts-with(@id,'desktop-btf-grid')]"));
                Console.WriteLine($"Grids available {btfgrids.Count}");
                for (int i = 1; i <= btfgrids.Count; i++)
                {
                    Console.WriteLine(driver.FindElement(By.XPath($"//*[@id='desktop-btf-grid-{i}']/descendant::h2")).Text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                driver.Close();
                driver.Quit();
            }





        }
    }
}
