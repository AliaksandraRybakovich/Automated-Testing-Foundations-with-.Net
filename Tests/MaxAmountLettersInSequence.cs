using Modules.DevelopmentAndBuildTools;
using NUnit.Framework;

namespace Tests
{
    public class MaxAmountLettersInSequence : BaseTest
    {
        public MaxAmountLettersInSequence() : base("MaxAmountLettersInSequence")
        { }

        [Test]
        [TestCase("fffttt444", 3)]
        [TestCase("4578962135642", 0)]
        [TestCase("", 0)]
        public void CheckMaxAmountLettersInSequenceReturnsCorrectValue(string message, int expectedReesult)
        {
            //act
            var actual = UniqueCharacters.MaxAmountLettersInSequence(message);

            //assert
            Assert.That(actual, Is.EqualTo(expectedReesult));
        }
    }
}
