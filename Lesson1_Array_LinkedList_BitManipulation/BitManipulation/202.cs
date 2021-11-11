using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BitManipulation
{
    class _202
    {
        //happy-number
        public bool IsHappy(int n)
        {
            //25 4+25=29 4+91 = 85 ;64+25=89;64+81=145 ;1+16+25=42;20;4
            //18 1+64=65;36"+25=61;36+1=37;9+49 58;25 64 89;64 81 145;1 16 25 42;16 4 20;4;
            //17 1 49 50 ; 25;4 25 29;4 81 85; 64 25 89;64 81 145
            int result = 0;
            while (result != 1 && result != 4)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += (n % 10) * (n % 10);
                    n = n / 10;
                }
                n = sum;
                result = sum;
            }

            if (result == 1) return true;

            return false;
        }
    }
}
