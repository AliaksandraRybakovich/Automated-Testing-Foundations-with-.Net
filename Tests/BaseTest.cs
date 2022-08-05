using NUnit.Framework;
using System;

namespace Tests
{
    public class BaseTest
    {
        private string _categoryName;

        public BaseTest(string categoryName)
        {
            _categoryName = categoryName;   
        }

        [OneTimeSetUp]
        public void Setup()
        {
            Console.WriteLine($"Begin Test of Method '{_categoryName}' ");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Console.WriteLine("End");
        }
    }
}
