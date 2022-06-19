﻿using System;
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

    }
}
