using Modules.DevelopmentAndBuildTools;
using NUnit.Framework;

namespace Tests
{
    public class MaxAmountDigitsInSequence : BaseTest
    {
        public MaxAmountDigitsInSequence() : base("MaxAmountDigitsInSequence")
        {     }       

        [Test]
        [TestCase("fffttt444", 3)]
        [TestCase("hfjgurorkmcnfhbtgej", 0)]
        [TestCase("", 0)]
        public void CheckMaxAmountDigitsInSequenceReturnsCorrectValue(string message, int expectedResult)
        {
            //act
            var actual = UniqueCharacters.MaxAmountDigitsInSequence(message);

            //assert
            Assert.That(actual, Is.EqualTo(expectedResult));
        }
    }
}

