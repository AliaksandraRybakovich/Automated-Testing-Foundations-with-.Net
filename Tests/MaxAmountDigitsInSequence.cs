using Modules.DevelopmentAndBuildTools;
using NUnit.Framework;
using System;

namespace Tests
{
    public class MaxAmountDigitsInSequence
    {
        int actual;
        int expected;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Begin Test of Method 'MaxAmountDigitsInSequence' ");
        }

        [Test]
        [Category("MaxAmountDigitsInSequence")]
        [TestCase("fffttt444", 3)]
        [TestCase("hfjgurorkmcnfhbtgej", 0)]
        public void CheckMaxAmountDigitsInSequence(string message, int expectedResult)
        {
            //act
            actual = UniqueCharacters.MaxAmountDigitsInSequence(message);

            //assert
            Assert.That(actual, Is.EqualTo(expectedResult));
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}

