using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace AdventOfCode2015.Days
{
    public class Day08
    {
        private readonly string[] input;

        public Day08()
        {
            input = File.ReadAllLines(@"../../../Input/Day08.txt");

            var result = Stage1();

            Console.WriteLine(result);

            Clipboard.SetText(result);
        }

        private string Stage1()
        {
            var values = input.Select(d => (d, Regex.Unescape(d), d.Count(), Regex.Unescape(d).Count() - 2));

            return (values.Sum(d => d.Item3) - values.Sum(d => d.Item4)).ToString();
        }

        private string Stage2()
        {
            return "";
        }
    }
}
