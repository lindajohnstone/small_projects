using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>() { "Seven", "even",
                    "Maven", "Amen", "eleven" };
            /* 
                The RegexOptions.Compiled option specifies that the regular expression is compiled to an assembly. 
                This yields faster execution but increases startup time. 
            */
            var rx = new Regex(@".even", RegexOptions.Compiled); 

            foreach (string word in words)
            {
                if (rx.IsMatch(word))
                {
                    Console.WriteLine($"{word} does match");
                }
                else
                {
                    Console.WriteLine($"{word} does not match");
                }
            }
        }
    }
}
