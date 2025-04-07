using LeetCodeTest.Core.Entities;
using System;
using System.Collections;

namespace LeetCodeName.Core
{
    public class LeetCodeLib
    {
        //Write a method that converts Roman input to a decimal number 

        public int RomanToInt(string s)
        {
            var total = 0;
            var num = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case 'I': num = 1; break;
                    case 'V': num = 5; break;
                    case 'X': num = 10; break;
                    case 'L': num = 50; break;
                    case 'C': num = 100; break;
                    case 'D': num = 500; break;
                    case 'M': num = 1000; break;
                }

                if (4 * num < total)
                    total -= num;
                else
                    total += num;
            }



            return total;
        }

        //Write a method that converts decimal numbers to Romannumbers 

        public string IntToRoman(int s)
        {
            string result = string.Empty;
            string[] romanLetters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            int i = 0;
            while (s != 0)
            {
                if (s >= numbers[i])
                {
                    s -= numbers[i];
                    result += romanLetters[i];
                }
                else
                {
                    i++;
                }
            }
            return result;

        }

        //Two Sum
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[1];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[i] = Array.IndexOf(nums, j);
                    }

                }
            }

            return result;

        }

        //Int to english words
        // example:
        // Input: num = 123
        // Output: "One Hundred Twenty Three"

        public string NumberToWords(int num)
        {
            string result = string.Empty;
            return string.Empty;
        }

        public bool IsPalindrome(int x)
        {
            var stringValue = x.ToString();
            string reverse = "";
            for (int i = stringValue.Length - 1; i >= 0; i--)
            {
                reverse += stringValue[i];
            }

            if (stringValue == reverse)
            {
                return true;
            }

            return false;
        }

        //Sum binary strings this code failed on leetcode so i steel need to take a look at it 

        public string AddBinary(string a, string b)
        {
            var val1 = int.Parse(a);
            var val2 = int.Parse(b);

            int i = 0, rem = 0, res = 0;
            int[] sum = new int[30];


            while (val1 != 0 || val2 != 0)
            {
                sum[i++] = (val1 % 10 + val2 % 10 + rem) % 2;
                rem = (val1 % 10 + val2 % 10 + rem) / 2;
                val1 = val1 / 10;
                val2 = val2 / 10;
            }
            if (rem != 0)
                sum[i++] = rem;

            i = i - 1;

            while (i >= 0)
                res = res * 10 + sum[i--];
            return res.ToString();
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            //A PERFECT EXAMPLE TO USE RECURSION SINCE U ALWAYS HAVE TO GO INTO THE .NEXT + REST WAS SIMPLE JUST CHECKING VALUES
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }

            list2.next = MergeTwoLists(list1, list2.next);
            return list2;

        }

        public int RemoveDuplicates(int[] nums)
        {
            //Input: nums = [1, 1, 2]
            //Output: 2, nums = [1, 2, _]

            int total = 0;
            int currentNumber = int.MinValue;

            foreach (int num in nums)
            {
                if (currentNumber != num)
                {
                    total++;
                    nums[total - 1] = num;
                }
                ;
                currentNumber = num;
            }
            return total;
        }

        public int RemoveElement(int[] nums, int val)
        {
            Int16 total = 0;

            foreach (Int16 num in nums)
            {
                if (num != val)
                {

                    total++;
                    nums[total - 1] = num;

                }

            }

            return total;
        }

        public bool IsValid(string s)
        {

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(')
                    stack.Push(c);
                else if (c == '[')
                    stack.Push(c);
                else if (c == '{')
                    stack.Push(c);

                if (stack.Count == 0)
                    return false;
                else if (c == ')')
                {
                    if (stack.Peek().ToString() == "(")
                    {
                        stack.Pop();
                    }
                    else
                        return false;
                }
                else if (c == ']')
                {
                    if (stack.Peek().ToString() == "[")
                    {
                        stack.Pop();
                    }
                    else
                        return false;
                }
                else if (c == '}')
                {
                    if (stack.Peek().ToString() == "{")
                    {
                        stack.Pop();
                    }
                    else
                        return false;
                }

            }

            if (stack.Count != 0)
                return false;

            return true;
        }

        public int StrStr(string haystack, string needle)
        {
            int index = haystack.IndexOf(needle, StringComparison.OrdinalIgnoreCase);
            return index;
        }

        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
                    return i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    return i + 1;
            }

            return -1;
        }

        public int LengthOfLastWord(string s)
        {
            var charArr = s.ToCharArray();
            var reversedString = charArr.Reverse();
            string result = string.Empty;
            bool isWord = false;

            if (!s.Contains(' ', StringComparison.OrdinalIgnoreCase))
                return s.Length;

            foreach (char c in reversedString)
            {
                if (isWord && c == ' ')
                    return result.Length;

                if (c != ' ')
                {
                    isWord = true;
                }

                if (isWord)
                {
                    result += c;
                }
            }

            return result.Length;
        }

        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
           
            return result;
        }



    }
}