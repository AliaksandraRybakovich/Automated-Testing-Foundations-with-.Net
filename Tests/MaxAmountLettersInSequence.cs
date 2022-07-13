using Modules.DevelopmentAndBuildTools;
using NUnit.Framework;
using System;

namespace Tests
{
    public class MaxAmountLettersInSequence
    {
        int actual;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Begin Test of Method 'MaxAmountLettersInSequence' ");
        }

        [Test]
        [Category("MaxAmountLettersInSequence")]
        [TestCase("fffttt444", 3)]
        [TestCase("4578962135642", 0)]
        public void CheckMaxAmountLettersInSequence(string message, int expectedReesult)
        {
            //act
            actual = UniqueCharacters.MaxAmountLettersInSequence(message);

            //assert
            Assert.That(actual, Is.EqualTo(expectedReesult));
        }

        [TearDown]
        public void Postcondition()
        {
            Console.WriteLine("End");
        }
    }
}
