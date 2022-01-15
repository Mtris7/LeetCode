using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _949
    {
        //https://leetcode.com/problems/largest-time-for-given-digits/
        public string LargestTimeFromDigits(int[] arr)
        {
            string res = "";
            int len = 0;
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < 4; i++)
            {
                if (dic.ContainsKey(arr[i])) dic[arr[i]]++;
                else dic[arr[i]] = 1;

                if (arr[i] > 5) len++;
            }
            if (len < 2 && dic.ContainsKey(2)) // format 2x:xx.
            {
                res += 2;
                dic[2]--;

                int second_hour = -1;
                var list_hour = dic.Where(x => x.Key < 4 && dic[x.Key] > 0).Select(x => x.Key).OrderByDescending(x => x);
                if (list_hour.Any()) second_hour = list_hour.First();
                if (second_hour == -1) return "";
                res += second_hour;
                dic[second_hour]--;

                res += ":";

                int first_minute = -1;
                var list_minute = dic.Where(x => x.Key < 6 && dic[x.Key] > 0).Select(x => x.Key).OrderByDescending(x => x);
                if (list_minute.Any()) first_minute = list_minute.First();
                else return "";
                res += first_minute;
                dic[first_minute]--;

                var second_minute = dic.Where(x => dic[x.Key] > 0).Select(x => x.Key).First();
                res += second_minute;
                dic[second_minute]--;
                return res;

            }
            else
            {
                int first_hour = -1;
                var list_hour = dic.Where(x => x.Key < 2 && dic[x.Key] > 0).Select(x => x.Key).OrderByDescending(x => x);
                if (list_hour.Any()) first_hour = list_hour.First();
                else return "";
                res += first_hour;
                dic[first_hour]--;

                var second_hour = dic.Where(x => dic[x.Key] >= 1).Select(x => x.Key).OrderByDescending(x => x).First();
                res += second_hour;
                dic[second_hour]--;
                res += ":";


                int first_minute = -1;
                var list_minute = dic.Where(x => x.Key < 6 && dic[x.Key] > 0).Select(x => x.Key).OrderByDescending(x => x);
                if (list_minute.Any()) first_minute = list_minute.First();
                else return "";
                res += first_minute;
                dic[first_minute]--;

                var second_minute = dic.Where(x => dic[x.Key] >= 1).Select(x => x.Key).First();
                res += second_minute;
                dic[second_minute]--;
                return res;
            }
        }
    }
}
