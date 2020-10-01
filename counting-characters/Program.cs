using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace counting_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Console.WriteLine("Enter word(s) for character count");

            string input = Console.ReadLine().ToUpper();
            input = Regex.Replace(input, "[^a-zA-Z]", String.Empty);

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (!counts.Keys.Contains(c))
                {
                    counts.Add(c, 1);
                }
                else
                {
                    counts[c]++;
                }
            }

            foreach (KeyValuePair<char, int> count in counts)
            {
                Console.WriteLine(count.Key + ": " + count.Value);
            }

            Console.ReadLine();
        }
    }
}
