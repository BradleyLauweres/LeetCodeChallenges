using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeName.Core;

class LeetCode
{
    static void Main(string[] args)
    {
        LeetCodeLib test = new LeetCodeLib();
        Console.WriteLine(test.RomanToInt("III"));
        Console.WriteLine(test.RomanToInt("LVIII"));
        Console.WriteLine(test.RomanToInt("MCMXCIV"));
    }
}
