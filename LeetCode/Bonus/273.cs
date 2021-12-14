using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _273
    {
        //https://leetcode.com/problems/integer-to-english-words/
        public string NumberToWords(int num)
        {
            var dic = new Dictionary<int, string>();
            dic.Add(1000000000, "Billion");
            dic.Add(1000000, "Million");
            dic.Add(1000, "Thousand");
            dic.Add(100, "Hundred");
            dic.Add(90, "Ninety");
            dic.Add(80, "Eighty");
            dic.Add(70, "Seventy");
            dic.Add(60, "Sixty");
            dic.Add(50, "Fifty");
            dic.Add(40, "Forty");
            dic.Add(30, "Thirty");
            dic.Add(20, "Twenty");
            dic.Add(19, "Nineteen");
            dic.Add(18, "Eighteen");
            dic.Add(17, "Seventeen");
            dic.Add(16, "Sixteen");
            dic.Add(15, "Fifteen");
            dic.Add(14, "Fourteen");
            dic.Add(13, "Thirteen");
            dic.Add(12, "Twelve");
            dic.Add(11, "Eleven");
            dic.Add(10, "Ten");
            dic.Add(9, "Nine");
            dic.Add(8, "Eight");
            dic.Add(7, "Seven");
            dic.Add(6, "Six");
            dic.Add(5, "Five");
            dic.Add(4, "Four");
            dic.Add(3, "Three");
            dic.Add(2, "Two");
            dic.Add(1, "One");
            dic.Add(0, "Zero");
            var result = "";
            result = EnglishWord(num, dic);
            return result;
        }
        private string result = "";
        public string EnglishWord(int num, Dictionary<int, string> dic)
        {
            if (!string.IsNullOrEmpty(result) && num < 100 && num > 0)
                result += " ";
            if (num >= 1000000000)
            {
                EnglishWord(num / 1000000000, dic);
                result += " " + dic[1000000000];
                num %= 1000000000;
                EnglishWord(num, dic);

                return result;
            }
            else if (num >= 1000000)
            {
                EnglishWord(num / 1000000, dic);
                result += " " + dic[1000000];
                num %= 1000000;
                EnglishWord(num, dic);

                return result;
            }
            else if (num >= 1000)
            {
                EnglishWord(num / 1000, dic);
                result += " " + dic[1000];
                num %= 1000;
                EnglishWord(num, dic);

                return result;
            }
            else if (num >= 100)
            {
                EnglishWord(num / 100, dic);
                result += " " + dic[100];
                num %= 100;
                EnglishWord(num, dic);

                return result;
            }
            else if (num >= 90)
            {
                result += dic[90];
                num -= 90;
                EnglishWord(num, dic);

                return result;

            }
            else if (num >= 80)
            {
                result += dic[80];
                num -= 80;
                EnglishWord(num, dic);

                return result;
            }
            else if (num >= 70)
            {
                result += dic[70];
                num -= 70;
                EnglishWord(num, dic);

                return result;

            }
            else if (num >= 60)
            {
                result += dic[60];
                num -= 60;
                EnglishWord(num, dic);

                return result;
            }
            else if (num >= 50)
            {
                result += dic[50];
                num -= 50;
                EnglishWord(num, dic);

                return result;
            }
            else if (num >= 40)
            {
                result += dic[40];
                num -= 40;
                EnglishWord(num, dic);

                return result;
            }

            else if (num >= 30)
            {
                result += dic[30];
                num -= 30;
                EnglishWord(num, dic);

                return result;
            }

            else if (num >= 20)
            {
                result += dic[20];
                num -= 20;
                EnglishWord(num, dic);

                return result;
            }
            else if (num == 19)
            {
                return result += dic[19];
            }
            else if (num == 18)
            {
                return result += dic[18];
            }
            else if (num == 17)
            {
                return result += dic[17];
            }
            else if (num == 16)
            {
                return result += dic[16];
            }
            else if (num == 15)
            {
                return result += dic[15];
            }
            else if (num == 14)
            {
                return result += dic[14];
            }
            else if (num == 13)
            {
                return result += dic[13];
            }
            else if (num == 12)
            {
                return result += dic[12];
            }
            else if (num == 11)
            {
                return result += dic[11];
            }
            else if (num == 10)
            {
                return result += dic[10];
            }
            else if (num == 9)
            {
                return result += dic[9];
            }
            else if (num == 8)
            {
                return result += dic[8];
            }
            else if (num == 7)
            {
                return result += dic[7];
            }
            else if (num == 6)
            {
                return result += dic[6];
            }
            else if (num == 5)
            {
                return result += dic[5];
            }
            else if (num == 4)
            {
                return result += dic[4];
            }
            else if (num == 3)
            {
                return result += dic[3];
            }
            else if (num == 2)
            {
                return result += dic[2];
            }
            else if (num == 1)
            {
                return result += dic[1];
            }
            else
            {
                if (string.IsNullOrEmpty(result))
                    result += dic[0];
                return result;
            }

        }
    }
}
