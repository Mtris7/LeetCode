using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MyCalendar
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        List<int> list = new List<int>();
        public MyCalendar()
        {


        }

        public bool Book(int start, int end)
        {
            if (dic.Count == 0)
            {
                dic[start] = end;
                list.Add(start);
                return true;
            }

            var arr = list.ToArray();
            Array.Sort(arr);
            int l = 0;
            int r = arr.Length - 1;
            int start_accept = -1;
            int end_accept = int.MaxValue;
            while (l < r)
            {
                //if(arr[l] == start || arr[r] == start) return false;

                int mid = (l + r) / 2;
                if (arr[mid] <= start)
                {
                    start_accept = Math.Max(arr[mid], start_accept);
                    l = mid + 1;

                }
                else
                {
                    end_accept = Math.Min(arr[mid], end_accept);
                    r = mid - 1;
                }
            }
            if (!(start_accept != -1 || dic[start_accept] <= start)) return false;
            if (!(end_accept != int.MaxValue || end <= end_accept)) return false;

            dic[start] = end;
            list.Add(start);
            return true;

        }
    }
}
