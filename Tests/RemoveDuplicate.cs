using Modules.DevelopmentAndBuildTools;
using NUnit.Framework;
using System;

namespace Tests
{
    public class RemoveDuplicate : BaseTest
    {
        public RemoveDuplicate() : base("RemoveDuplicate")
        { }

        [Test]
        [TestCase("fffttt444")]
        public void CheckRemoveDuplicateReturnsCorrectValue(string message)
        {
            //act
            var actual = UniqueCharacters.RemoveDuplicate(message);
            var expected = "ft4";

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("")]
        public void CheckRemoveDuplicateThrowsExceptionWhenInputStringIsEmpty(string message)
        {
            //assert    
           Assert.Throws<ArgumentException>(() => UniqueCharacters.RemoveDuplicate(message));
        }
    }
}