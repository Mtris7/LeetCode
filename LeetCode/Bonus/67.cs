using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _67
    {
        public string AddBinary(string a, string b)
        {
            string aR = "";
            string bR = "";
            for (int i = a.Length - 1; i >= 0; i--)
                aR += a[i];
            for (int i = b.Length - 1; i >= 0; i--)
                bR += b[i];
            int size = a.Length < b.Length ? a.Length : b.Length;
            string res = "";
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                if (aR[i] == '1' && bR[i] == '1')
                {
                    if (temp == 0)
                        res = "0" + res;
                    else
                        res = "1" + res;
                    temp = 1;
                }
                else if (aR[i] == '0' && bR[i] == '0')
                {
                    if (temp == 0)
                        res = "0" + res;
                    else
                        res = "1" + res;
                    temp = 0;
                }
                else
                {
                    //a = 1 || b = 1
                    if (temp == 0)
                        res = "1" + res;
                    else
                        res = "0" + res;
                }

            }
            if (a.Length < b.Length)
            {
                for (int i = b.Length - size - 1; i >= 0; i--)
                {
                    if (b[i] == '1')
                    {
                        if (temp == 0)
                            res = "1" + res;
                        else
                            res = "0" + res;
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
                for (int i = a.Length - size - 1; i >= 0; i--)
                {
                    if (a[i] == '1')
                    {
                        if (temp == 0)
                            res = "1" + res;
                        else
                            res = "0" + res;
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
