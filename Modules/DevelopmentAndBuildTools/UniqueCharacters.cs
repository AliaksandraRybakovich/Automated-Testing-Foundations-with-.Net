using System.Linq;

namespace Modules.DevelopmentAndBuildTools
{
    internal class UniqueCharacters
    {
        public static string RemoveDuplicate(string message)
        {
            var charSequence = message.Distinct(); 
            return new string(charSequence.ToArray());
        }
    }
}
