namespace LeetCodeName.Core
{
    public class LeetCodeLib
    {
        //Write a method that converts Roman input to a decimal number 

        public int RomanToInt(string s)
        {
            var total = 0; 
            var num = 0;

            for(int i = s.Length -1; i >= 0; i--)
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
            string[] romanLetters = {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I" };
            int[] numbers = {1000,900,500,400,100, 90,50,40,10,9,5,4,1 };

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
                        result[i] = Array.IndexOf(nums,j);
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
            for (int i = stringValue.Length-1; i >= 0; i--)
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

    }
}