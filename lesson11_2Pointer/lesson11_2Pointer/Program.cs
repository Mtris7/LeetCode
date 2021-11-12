using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson11_2Pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            //845   https://leetcode.com/problems/longest-mountain-in-array/
            //26    https://leetcode.com/problems/remove-duplicates-from-sorted-array/
            //485   https://leetcode.com/problems/max-consecutive-ones/
            //167   https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
            //15    https://leetcode.com/problems/3sum/

            //sub   https://leetcode.com/problems/two-sum-less-than-k/

            //sub   https://leetcode.com/problems/3sum-smaller/
            //18    https://leetcode.com/problems/4sum/ (sau đó chắc chắn rằng bạn có thể giải quyết vấn đề x-Sum)
            //240   https://leetcode.com/problems/search-a-2d-matrix-ii/
            //3     https://leetcode.com/problems/longest-substring-without-repeating-characters/
            //sub   https://leetcode.com/problems/longest-substring-with-at-most-k-distinct-characters/
            //sub   https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/

            //904   https://leetcode.com/problems/fruit-into-baskets/
            //713   https://leetcode.com/problems/subarray-product-less-than-k/
            //76    https://leetcode.com/problems/minimum-window-substring/
            //      https://leetcode.com/problems/subarrays-with-k-different-integers/ (cái này khá khó, không giải được thì tìm hiểu giải pháp)
            //      https://leetcode.com/.../longest-well-performing-interval/ => chắc chắn bạn hiểu tại sao không thể sử dụng 2 điểm cho vấn đề này, sau đó nghĩ cách khác.
            //      https://leetcode.com/prob.../minimum-cost-to-connect-sticks/
            //      https://leetcode.com/.../maximum-score-from-removing-stones/
            //      https://leetcode.com/pro.../kth-largest-element-in-a-stream/
            //      https://leetcode.com/problems/top-k-frequent-elements/ (giải quyết bởi Qselect, thử lại với đống, so sánh thời gian chạy)
            //      https://leetcode.com/pro.../kth-largest-element-in-an-array/

            _992.SubarraysWithKDistinct(new int[] { 2   ,1  , 1  , 1  , 3  , 4 ,5,16,17,18,19}, 2);//1, 2, 1, 3, 4 ; ... 1, 1, 2, 1, 2, 3, 4
            Console.WriteLine("Hello World!");
        }
        
    }
}
