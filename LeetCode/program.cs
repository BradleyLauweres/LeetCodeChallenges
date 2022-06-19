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
        LeetCodeLib challenges = new LeetCodeLib();

        //Roman To Int
        Console.WriteLine(challenges.RomanToInt("III"));
        Console.WriteLine(challenges.RomanToInt("LVIII"));
        Console.WriteLine(challenges.RomanToInt("MCMXCIV"));

        //Int to Roman
        Console.WriteLine(challenges.IntToRoman(3));
        Console.WriteLine(challenges.IntToRoman(58));
        Console.WriteLine(challenges.IntToRoman(1994));

        int[] nums = { 2, 7, 11, 15 };
        Console.WriteLine(challenges.TwoSum(nums,9));
        Console.WriteLine(challenges.IsPalindrome(505));

        Console.WriteLine(challenges.AddBinary("11", "1"));
        Console.WriteLine(challenges.AddBinary("1010", "1011"));

    }
}
