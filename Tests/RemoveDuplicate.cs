using Modules.DevelopmentAndBuildTools;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        string actual;
        string expected;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Begin Test of Method 'RemoveDuplicate' ");
        }

        [Test]
        [Category ("RemoveDuplicate")]
        [TestCase("fffttt444")]
        public void CheckRemoveDuplicate(string message)
        {
            //act
            actual = UniqueCharacters.RemoveDuplicate(message);
            expected = "ft4";

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("")]
        public void CheckNullUniqueCharacters(string message)
        {
            //assert    
           Assert.Throws<ArgumentException>(() => UniqueCharacters.RemoveDuplicate(message));
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}