using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _67
    {
        public string AddBinary(string a, string b)
        {
            int size = a.Length < b.Length ? a.Length : b.Length;
            int temp = 0;
            string res = "";
            int i = size - 1;
            for (; i >= 0; i--)
            {
                if (a[i] == '1' && b[i] == '1')
                {
                    if (temp == 0)
                        res = "0" + res;
                    else
                        res = "1" + res;
                    temp = 1;
                }
                else if (a[i] == '0' && b[i] == '0')
                {
                    if (temp == 0)
                        res = "0" + res;
                    else
                        res = "1" + res;
                    temp = 0;
                }
                else
                { //a or b = 1
                    if (temp == 0)
                        res = "1" + res;
                    else
                        res = "0" + res;
                    temp = 0;
                }

            }
            if (a.Length < b.Length)
            {
                i = b.Length - 1;
                for (; i > size - 1; i--)
                {
                    if (b[i] == '1')
                    {
                        if (temp == 1)
                            res = "0" + res;
                        else
                            res = "1" + res;
                    }
                    else
                    {
                        if (temp == 1)
                        {
                            res = "1" + res;
                            temp = 0;
                        }
                        else
                            res = "0" + res;
                    }
                }
            }
            else
            {
                i = a.Length - 1;
                for (; i > size - 1; i--)
                {
                    if (a[i] == '1')
                    {
                        if (temp == 1)
                            res = "0" + res;
                        else
                            res = "1" + res;
                    }
                    else
                    {
                        if (temp == 1)
                        {
                            res = "1" + res;
                            temp = 0;
                        }
                        else
                            res = "0" + res;
                    }
                }
            }
            if (temp == 1) res = "1" + res;
            return res;
        }
    }
}
