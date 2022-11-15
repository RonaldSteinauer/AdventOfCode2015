using System.Security.Cryptography;
using System.Windows;

namespace AdventOfCode2015.Days
{
    public class Day04
    {
        const string input = "ckczppom";

        public Day04()
        {
            var result = Stage2();

            Console.WriteLine(result);

            Clipboard.SetText(result);
        }

        private string Stage1()
        {
            return DoMD5("00000");
        }

        private string Stage2()
        {
            return DoMD5("000000");
        }

        private static string DoMD5(string startPattern)
        {
            int count = 0;
            string result = "";

            while (!result.StartsWith(startPattern))
            {
                count++;

                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input + count);
                byte[] hashBytes = MD5.HashData(inputBytes);

                result = Convert.ToHexString(hashBytes);
            }

            return count.ToString();
        }
    }
}
