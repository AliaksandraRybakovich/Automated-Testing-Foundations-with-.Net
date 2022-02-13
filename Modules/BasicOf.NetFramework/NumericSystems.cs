using System;
using System.Collections.Generic;

namespace BasicOf.NetFramework
{
    internal class NumericSystems
    {
        public string ConversionNumber(int number, int numericSystem)
        {
            if ((numericSystem > 20) || (numericSystem < 2))
            {
                throw new ArgumentException("Введите число от 2 до 20");
            }
            var result = string.Empty;
            List<char> alphabet = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' }; 
            List<string> arr = new List<string>();
            while (number > 0)
            {
                var remainderDivision = number % numericSystem;
                if (remainderDivision >= 10)
                {
                    arr.Add(alphabet[remainderDivision].ToString()); 
                }
                else
                {
                    arr.Add(remainderDivision.ToString());
                }
                number /= numericSystem;
            }
            arr.Reverse();

            return String.Join("", arr);
        }
    }
}
