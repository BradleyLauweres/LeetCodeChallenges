using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeTest.Core.Entities;
using LeetCodeName.Core;

class LeetCode
{
    static void Main(string[] args)
    {
        LeetCodeLib challenges = new LeetCodeLib();

        RomanToInt(challenges);
        IntToRoman(challenges);
        TwoSum(challenges);
        IsPalindrome(challenges);
        AddBinary(challenges);
        IsValid(challenges);
        MergeTwoLists(challenges);
    }

    static void RomanToInt(LeetCodeLib challenges)
    {
        Console.WriteLine(challenges.RomanToInt("III"));
        Console.WriteLine(challenges.RomanToInt("LVIII"));
        Console.WriteLine(challenges.RomanToInt("MCMXCIV"));
    }
    static void IntToRoman(LeetCodeLib challenges)
    {
        Console.WriteLine(challenges.IntToRoman(3));
        Console.WriteLine(challenges.IntToRoman(58));
        Console.WriteLine(challenges.IntToRoman(1994));
    }
    static void TwoSum(LeetCodeLib challenges)
    {
        int[] nums = { 2, 7, 11, 15 };
        Console.WriteLine(challenges.TwoSum(nums, 9));
    }
    static void IsPalindrome(LeetCodeLib challenges)
    {
        Console.WriteLine(challenges.IsPalindrome(505));
    }
    static void AddBinary(LeetCodeLib challenges)
    {
        Console.WriteLine(challenges.AddBinary("11", "1"));
        Console.WriteLine(challenges.AddBinary("1010", "1011"));
    }
    static void IsValid(LeetCodeLib challenges)
    {
        Console.WriteLine(challenges.IsValid("()"));          //true
        Console.WriteLine(challenges.IsValid("()[]{}"));      //true
        Console.WriteLine(challenges.IsValid("(]"));          //false
        Console.WriteLine(challenges.IsValid("([])"));        //true
        Console.WriteLine(challenges.IsValid("([)]"));        //false
        Console.WriteLine(challenges.IsValid("(){}}{"));      //false
        Console.WriteLine(challenges.IsValid("({{{{}}}))"));  //false
    }
    static void MergeTwoLists(LeetCodeLib challenges)
    {
        ListNode listNode = new ListNode(1,new ListNode(2,new ListNode(4)));
        ListNode listNode1 = new ListNode(1,new ListNode(3,new ListNode(4)));
        Console.WriteLine(challenges.MergeTwoLists(listNode, listNode1).ToString());
       
    }

}

