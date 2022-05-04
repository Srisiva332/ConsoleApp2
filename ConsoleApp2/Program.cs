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
    public class Program : BaseClass
    {
        [Test]
        public void constructor()
        {
            
        }
        
    }

    [TestFixture]
    public class Program2 : BaseClass
    {
        
        public Program2() : base("BaseClass Constructor without parameter")
        {

        }
        [Test]
        public void Test1()
        {
            Console.WriteLine("Test Class");
        }

    }


    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass constructor without parameters");
        }
        public BaseClass(string message)
        {
            Console.WriteLine(message);
        }
    }
}
