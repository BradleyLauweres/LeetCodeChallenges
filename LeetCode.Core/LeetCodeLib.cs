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

    }
}