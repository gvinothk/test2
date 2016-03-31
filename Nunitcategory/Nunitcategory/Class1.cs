using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnit;
//using Nunitcategory;
//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

using MbUnit;
using MbUnit.Core;
using MbUnit.Framework;


namespace Nunitcategory
{
    [TestFixture]
    [Category("MathS")]
    public class TestClass
    {
        [Test]
        [Category("Rediff"), Row ("http://www.rediff.com")]
        [Category("google"), Row("http://www.google.com")]
        public void AddTest(string url)
        {
            //IWebDriver dr = new ChromeDriver(@"d:\chromedriver.exe");

            //dr.Navigate().GoToUrl(url);
            Console.WriteLine(url);
            Console.WriteLine("test1112121");
            Console.ReadLine();
            
        }

        [Test]
        [Category("test"), Row("http://www.rediff.com")]        
        public void AddTest1(string url)
        {
            //IWebDriver dr = new ChromeDriver(@"d:\chromedriver.exe");

            //dr.Navigate().GoToUrl(url);
            Console.WriteLine(url);
            Console.ReadLine();

        }

        [Test]
        [Category("test"), Row("http://www.rediff.com")]
        public void AddTest2(string url)
        {
            //IWebDriver dr = new ChromeDriver(@"d:\chromedriver.exe");

            //dr.Navigate().GoToUrl(url);
            Console.WriteLine(url);
            Console.ReadLine();

        } 
    }
}
