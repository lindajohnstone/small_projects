using System;
using System.Text.RegularExpressions;

namespace RegexOneReplaceString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets try and reverse the order of the day and month in a few date 
            // strings. Notice how the replacement string also contains metacharacters
            // (the back references to the captured groups) so we use a verbatim 
            // string for that as well.
            string pattern = @"([a-zA-Z]+) (\d+)";

            // This will reorder the string inline and print:
            //   24 of June, 9 of August, 12 of Dec
            // Remember that the first group is always the full matched text, so the 
            // month and day indices start from 1 instead of zero.
            string replacedString = Regex.Replace("June 24, August 9, Dec 12",
                pattern, @"$2 of $1");
            Console.WriteLine(replacedString);
        }
    }
}
