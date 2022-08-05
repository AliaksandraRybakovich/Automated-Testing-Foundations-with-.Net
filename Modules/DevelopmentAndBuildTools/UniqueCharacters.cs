using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Modules.DevelopmentAndBuildTools
{
    public class UniqueCharacters
    {
        public static string RemoveDuplicate(string message)
        {
            if (String.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException();
            }
            var charSequence = message.Distinct();
            return new string(charSequence.ToArray());
        }

        public static int MaxAmountLettersInSequence(string message)
        {
            var regex = new Regex("[0-9]");
            var messageWithoutNumber = regex.Replace(message, " ");

            return MaxNumberReccuringSymbolsInSequence(messageWithoutNumber);
        }

        public static int MaxAmountDigitsInSequence(string message)
        {
            var regex = new Regex(@"\D");
            var messageWithoutLetter = regex.Replace(message, " ");

            return MaxNumberReccuringSymbolsInSequence(messageWithoutLetter);
        }

        private static int MaxNumberReccuringSymbolsInSequence(string messageWithout)
        {
            if(String.IsNullOrWhiteSpace(messageWithout))
            { return 0; }

            int count = 0;
            for (int i = 0; i < messageWithout.Length; i++)
            {
                int currentNumber = 1;
                for (int j = i + 1; j < messageWithout.Length; j++)
                {
                    if (messageWithout[i] != messageWithout[j])
                    {
                        break;
                    }
                    else if (!char.IsWhiteSpace(messageWithout[i]))
                    { currentNumber++; }
                }

                if(currentNumber > count)
                {
                    count = currentNumber;
                }
            }
            return count;
        }

    }
}
