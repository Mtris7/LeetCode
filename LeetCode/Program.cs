using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region lesson1

            //ARRAY
            //https://leetcode.com/problems/running-sum-of-1d-array/running-sum-of-1d-array
            //https://leetcode.com/problems/range-sum-query-immutable/
            //https://leetcode.com/problems/range-sum-query-2d-immutable/
            //https://leetcode.com/problems/move-zeroes/
            //https://leetcode.com/problems/sort-colors/
            //https://leetcode.com/problems/sort-array-by-parity
            //https://leetcode.com/problems/sort-array-by-parity-ii/ 

            //LINKED LIST
            //https://leetcode.com/problems/reverse-linked-list/ 
            //https://leetcode.com/problems/middle-of-the-linked-list
            //https://leetcode.com/problems/linked-list-cycle/
            //https://leetcode.com/problems/linked-list-cycle-ii/ 

            //BIT MANIPULATION
            //https://leetcode.com/problems/happy-number
            //https://leetcode.com/problems/number-of-1-bits/
            //https://leetcode.com/problems/power-of-two/
            //https://leetcode.com/problems/subsets/
            #endregion

            #region lesson3
            //Implement quick sort with randomised pivot.
            //
            //88    https://leetcode.com/problems/merge-sorted-array/
            //148   https://leetcode.com/problems/sort-list/  unfinish
            //215   https://leetcode.com/pro.../kth-largest-element-in-an-array/
            //973   https://leetcode.com/problems/k-closest-points-to-origin
            //sub   https://leetcode.com/pro.../moving-average-from-data-stream/
            //622   https://leetcode.com/problems/design-circular-queue/

            //          Read again the algo and implement
            //      https://leetcode.com/problems/sliding-window-maximum/
            //1047  https://leetcode.com/.../remove-all-adjacent-duplicates.../
            //20    https://leetcode.com/problems/valid-parentheses/
            //150   https://leetcode.com/.../evaluate-reverse-polish-notation/

            //       If you still have time:
            //      https://leetcode.com/.../the-k-strongest-values-in-an-array/ 
            //      https://leetcode.com/.../find-kth-largest-xor-coordinate.../
            //      https://hoangdinhquang.me/a-note-on-an-interesting.../
            //227   https://leetcode.com/problems/basic-calculator-ii/
            //sub   https://leetcode.com/problems/basic-calculator-iii/
            //      https://leetcode.com/problems/basic-calculator/

            //string s = "(1+(4+5+2)-3)+(6+8)";
            //List<int> list = new List<int>();
            //list.Add(3);
            //int a = list.Last();
            //if (s.Contains('('))
            //{
            //    int k = s.IndexOf('(');
            //    string b = s.Substring(k + 1);

            //}
            //_148.quickSort(new int[] { 10, 80, 30, 90, 40, 50, 70 }, 0, 6);
            //_148.partition(new int[] { 10, 80, 30, 90, 40, 50, 70 }, 0, 6);
            //IsPowofTwo(0);
            //IsPowofTwo(1);
            //IsPowofTwo(2);
            //JudgeSquareSum(3);
            //var l1 = new ListNode(1);
            //l1.next = new ListNode(2);
            //l1.next.next = new ListNode(4);
            //var l2 = new ListNode(1);
            //l2.next = new ListNode(2);
            //l2.next.next = new ListNode(3);
            //_21.MergeTwoLists(l1, l2);
            #endregion

            #region lesson5
            //217   https://leetcode.com/problems/contains-duplicate/
            //219   https://leetcode.com/problems/contains-duplicate-ii/
            //1     https://leetcode.com/problems/two-sum/
            //454   https://leetcode.com/problems/4sum-ii/
            //sub   https://leetcode.com/problems/palindrome-permutation/
            //sub   https://leetcode.com/problems/subarray-sums-divisible-by-k/
            //387   https://leetcode.com/.../first-unique-character-in-a-string/
            //sub   https://leetcode.com/problems/find-anagram-mappings/
            //1748  https://leetcode.com/problems/sum-of-unique-elements/
            #endregion

            #region Lesson7 DFS Graph
            //Sub   https://leetcode.com/.../number-of-connected-components.../
            //547   https://leetcode.com/problems/number-of-provinces/
            //841   https://leetcode.com/problems/keys-and-rooms/
            //200   https://leetcode.com/problems/number-of-islands/
            //695   https://leetcode.com/problems/max-area-of-island/
            //404   https://leetcode.com/problems/sum-of-left-leaves/
            //111   https://leetcode.com/problems/minimum-depth-of-binary-tree/
            //104   https://leetcode.com/problems/maximum-depth-of-binary-tree/
            //543   https://leetcode.com/problems/diameter-of-binary-tree/ 
            //508   https://leetcode.com/problems/most-frequent-subtree-sum/ unfinish
            //Sub   https://leetcode.com/problems/diameter-of-n-ary-tree/
            //687   https://leetcode.com/problems/longest-univalue-path/
            //1372  https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree/
            //337   https://leetcode.com/problems/house-robber-iii/
            //144   https://leetcode.com/problems/binary-tree-preorder-traversal/
            //94    https://leetcode.com/problems/binary-tree-inorder-traversal/
            //145   https://leetcode.com/problems/binary-tree-postorder-traversal/
            //590   https://leetcode.com/problems/n-ary-tree-postorder-traversal/
            #endregion

            #region Lesson 8
            //https://leetcode.com/problems/number-of-islands (thực hiện sử dụng BFS)
            //https://leetcode.com/problems/number-of-provinces/ (thực hiện sử dụng BFS)
            //429   https://leetcode.com/problems/n-ary-tree-level-order-traversal/
            //107   https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
            //1302  https://leetcode.com/problems/deepest-leaves-sum/
            //199   https://leetcode.com/problems/binary-tree-right-side-view/
            //1091  https://leetcode.com/problems/shortest-path-in-binary-matrix/
            //sub   https://leetcode.com/problems/minimum-knight-moves/
            //127   https://leetcode.com/problems/word-ladder/
            //433   https://leetcode.com/problems/minimum-genetic-mutation/
            //1293  https://leetcode.com/.../shortest-path-in-a-grid-with.../ unfinish
            //773   https://leetcode.com/problems/sliding-puzzle/
            #endregion

            #region Lesson9
            //Binary Search

            //sub   https://leetcode.com/problems/search-in-a-sorted-array-of
            //852   https://leetcode.com/problems/peak-index-in-a-mountain-array/
            //33    https://leetcode.com/problems/search-in-rotated-sorted-array/
            //153   https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
            //81    https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
            //69    https://leetcode.com/problems/sqrtx/
            //sub   https://leetcode.com/problems/path-with-maximum-minimum-value/
            //1760  https://leetcode.com/problems/minimum-limit-of-balls-in-a-bag/
            //1631  https://leetcode.com/problems/path-with-minimum-effort/
            //sub   https://leetcode.com/problems/divide-chocolate/

            //BST
            //701   https://leetcode.com/problems/insert-into-a-binary-search-tree/
            //700   https://leetcode.com/problems/search-in-a-binary-search-tree/
            //450   https://leetcode.com/problems/delete-node-in-a-bst/
            #endregion

            #region Lesson11
            //2Pointer
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

            //heap
            //sub   https://leetcode.com/problems/minimum-cost-to-connect-sticks/
            //1753  https://leetcode.com/problems/maximum-score-from-removing-stones/

            //https://leetcode.com/problems/kth-largest-element-in-a-stream/
            //347 https://leetcode.com/problems/top-k-frequent-elements/
            //215   https://leetcode.com/problems/kth-largest-element-in-an-array/
            //
            //
            //295 https://leetcode.com/problems/find-median-from-data-stream/
            #endregion

            #region Lesson13
            //[[1,2,1],[2,3,2],[1,3,4]]
            //_743.NetworkDelayTime(new int[3][] { new int[] { 1, 2, 1 }, new int[] { 2, 3, 2 }, new int[] { 1, 3, 4 } }, 3, 1);

            //n = 3, edges = [[0,1],[1,2],[0,2]], succProb = [0.5,0.5,0.2], start = 0, end = 2

            //            5
            //[[1, 4],[2,4],[0,4],[0,3],[0,2],[2,3]]
            //[0.37,0.17,0.93,0.23,0.39,0.04]
            //3
            //4
            //_1514.MaxProbability(5, new int[6][] { new int[] { 1, 4 }, new int[] { 2, 4 }, new int[] { 0, 4 }, new int[] { 0, 3 }, new int[] { 0, 2 }
            //                    , new int[] { 2,3}} , new double[] { 0.37, 0.17, 0.93, 0.23, 0.39, 0.04 }, 3, 4);


            //            3
            //[[0, 1, 100],[1,2,100],[0,2,500]]
            //0
            //2
            //1

            //5
            //[[0, 1, 5],[1,2,5],[0,3,2],[3,1,2],[1,4,1],[4,2,1]]
            //0
            //2
            //2
            //_787.FindCheapestPrice(5, new int[3][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } },0,2,1);
            //_787.FindCheapestPrice(5, new int[6][] { new int[] { 0, 1, 5 }, new int[] { 1, 2, 5 }, new int[] { 0, 3, 2 } ,
            //                            new int[] { 3,1,2 }, new int[] { 1,4,1 }, new int[] { 4, 2, 1 } }, 0, 2, 2);
            //_990.EquationsPossible(new string[] { "a==b", "b==c", "c==d", "x!=c", "x==a" });

            //_952.largestComponentSize(new int[] { 4, 6, 15, 35 });

            //14
            //4
            //[[4, 2],[7,2],[4,3],[1,4],    [4,11],[6,8],[8,12],[12,5],     
            //[3,7],[12,6],[3,6],[11,9],    [6,9],[6,4],[4,9],[14,4],       [10,14],[14,2],[9,8],[8,7],
            //[13,14],[12,4],[7,4],[10,4], [1,6],[9,7],[5,13],[10,11],     [14,8],[5,6],[7,12],[11,5]
            //,[8,13],[4,8],[1,9],[8,2]     ,[1,13],[5,9],[12,1],[13,10],   [1,8],[10,6],[9,13],[6,11], [3,5],[5,2]]
            //_1627.AreConnected(14, 4, new int[10][] { new int[] {4,2}, new int[] { 7, 2 }, new int[] { 4, 3 },new int[] { 1, 4 },
            //                                        new int[] {4,11}, new int[] { 6,8 }, new int[] {8,12 },new int[] { 12, 5 },
            //                                        new int[] {3,7}, new int[] { 12,6 }});
            #endregion


            #region
            #endregion

            #region
            #endregion

            #region Lesson 15-16
            //https://leetcode.com/problems/minimum-cost-to-reach-city-with-discounts/
            //https://leetcode.com/problems/connecting-cities-with-minimum-cost
            //https://leetcode.com/problems/optimize-water-distribution-in-a-village
            #endregion

            _108 obj = new _108();
            obj.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });

            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            //byte[] salt = new byte[128 / 8];
            //using (var rngCsp = new RNGCryptoServiceProvider())
            //{
            //    rngCsp.GetNonZeroBytes(salt);
            //}
            //Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            //// derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            //string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            //    password: password,
            //    salt: salt,
            //    prf: KeyDerivationPrf.HMACSHA256,
            //    iterationCount: 100000,
            //    numBytesRequested: 256 / 8));
            //Console.WriteLine($"Hashed: {hashed}");
            Cal(new string[] { "5","2","C","D", "+" });


            Console.WriteLine("Hello World!");
        }
        public static int Cal(string[] ops)
        {
            var queue = new Stack<int>();
            for(int i = 0; i< ops.Length; i++)
            {
                if (ops[i] == "C")
                {
                    queue.Pop();
                }
                else if (ops[i] == "D")
                {
                    var node = queue.Pop();
                    queue.Push(node);
                    queue.Push(node * 2);
                }
                else if (ops[i] == "+")
                {
                    var node1 = queue.Pop();
                    var node2 = queue.Pop();
                    queue.Push(node2);
                    queue.Push(node1);
                    queue.Push(node2 + node1);

                }
                else
                    queue.Push(Convert.ToInt32(ops[i]));
            }
            int sum = 0;
            while(queue.Any())
            {
                var node = queue.Pop();
                sum += node;
            }
            return sum;
        }
        public static string ReverseOnlyLetters(string s)
        {
            string res = "";
            var dic = new Dictionary<int, char>();
            for(int i = 0; i<s.Length;i++)
            {
                if(Convert.ToInt32( s[i]) <65 && Convert.ToInt32(s[i]) > 90 && Convert.ToInt32(s[i]) <97
                   && Convert.ToInt32(s[i]) > 122)
                {
                    dic.Add(i, s[i]);
                }
                else
                {
                    res += s[i];
                }
            }
            var str = "";
            for(int i = res.Length - 1;i >= 0; i--)
            {
                str += res[i];
            }
            string result = "";
            for(int i = 0; i < s.Length; i++)
            {
                if(dic.ContainsKey(i))
                {
                    result += dic[i];
                }
                else
                {
                    result += res[i];
                }
            }
            return result;
        }
        static int[] parent;
        static int[] rank;
        public static int MinimumCost(int n, int[][] connections)
        {
            parent = new int[n + 1];
            rank = new int[n + 1];
            for (int i = 0; i <= n; i++)
                parent[i] = i;

            Array.Sort(connections, (a, b) => a[2].CompareTo(b[2]));

            int result = 0;
            foreach (var connection in connections)
            {
                if (Find(connection[0]) != Find(connection[1]))
                {
                    result += connection[2];
                    union(connection[0], connection[1]);
                }
            }
            for (int i = 2; i <= n; i++)
                if (Find(i) != Find(1))
                    return -1;
            return result;

        }
        static int Find(int x)
        {
            if (parent[x] == x)
                return x;
            else
                return parent[x] = Find(parent[x]);
        }
        static void union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);
            if (px != py)
            {
                if (rank[px] > rank[py])
                    parent[py] = px;
                else
                {
                    parent[px] = py;
                    if (rank[px] == rank[py])
                        rank[py]++;
                }
            }
        }
        public int SubArray(int[] nums, int s)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == s)
                {
                    count++;
                    continue;
                }
                else
                {
                    for (int j = i + 1; j < nums.Length; j++)
                        if (s - nums[i] == nums[j]) count++;
                }
            }
            return count;
        }
        public bool CheckSubarraySum(int[] nums, int k)
        {
            if (nums.Length < 2) return false;
            nums = PrefixSum(nums);
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var temp = nums[i] % k;
                if ((dic.ContainsKey(temp) && (i - dic[temp] > 1)) || (temp == 0 && i > 0))
                    return true;
                if (!dic.ContainsKey(temp))
                    dic.Add(temp, i);
            }
            return false;
        }
        private int[] PrefixSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }


        //search-insert-position
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            int i = nums.Length / 2;
            int indexTarget = i;
            if (nums[i] < target)
            {
                int[] nums1 = new int[nums.Length / 2];
                int index = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    nums1[index] = nums[j];
                    index++;
                }
                indexTarget += i + SearchInsert(nums1, target);
            }
            else if (nums[i] > target)
            {
                int[] nums1 = new int[nums.Length / 2];
                int index = 0;
                for (int j = 0; j < i - 1; j++)
                {
                    nums1[index] = nums[j];
                    index++;
                }
                indexTarget -= (i + SearchInsert(nums1, target));
            }
            return indexTarget;

        }
        //Implement strStr()
        public int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            return haystack.IndexOf(needle);
        }
        public int RemoveElement(int[] nums, int val)
        {
            /* i have a worst solution : we just create to loop 
             * 1, int i = 0 -> n and j : n -> 0 swap if nums[i] == val
             * after thinking some minute , i think i use 1 loop
             *  create first and last index in array
             *  swap i if nums[i] == val and decrease n 
             *  return n
             */
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                }
                else
                    i++;
            }
            return n;
        }
        public int RemoveDuplicates(int[] nums)
        {
            /* [0,0,1,1,1,2,2,3,3,4] remove duplicate
             * i think we should create count to count the number of the time number repeat
             * pivot : index change when value is distinct
             * create a list save values is distince for compare
             * loop i = 0 -> n and check duplicate
             * 
             */
            if (nums.Length == 0) return 0;
            int count = 1;
            int pivot = 1;
            List<int> list = new List<int>();
            list.Add(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (list.Contains(nums[i])) continue;
                else list.Add(nums[i]);
                nums[pivot] = nums[i];
                pivot++;
                count++;
            }
            return count;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            /* Longest Common Prefix
             * first : we create prefix with index = 0 in array
             * second : check index of prefix in array from index 1-> max
             * if not in : decrease prefix 1 char
             * example: ["flower","flow","flight"]
             * prefix = flower => check flow with flower => not in : prefix = flowe
             * not in againt we decrease prefix 1 last char: prefix = flow
             * now, we have two case : 1 , it have : return prefix or empty : return it 
             */
            if (strs.Length < 2) return strs[strs.Length - 1];

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            }
            return prefix;

        }
        //------------------
        //public int SubarraySum(int[] nums, int k)
        //{
        //    int sum = 0;
        //    int count = 0;
        //    Dictionary<int, int> dic = new Dictionary<int, int>();
        //    dic.Add(0, 1);
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //        if (dic.ContainsKey(sum - k))
        //            count += dic[sum - k];
        //        dic.Add(sum, 1);
        //    }
        //    return count;
        //}
        public int SubarraySum(int[] nums, int k)
        {
            /*
             * i have a worst solution: 
             * create sum and count  = 0;
             * we have two loop and check from 0 in array -> n : count the number of the time sum = k 
             * time O(n)
             * space O(1)
             * because value in nums has a negative, so i don't have bester solution
             * do you want to me improve solution or implementation
             */
            int sum = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = nums[i];
                if (sum == k) count++;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        /*
         * i have a worst solution to create two loop and check and count max sum like it
         * [-2,1,-3,4,-1,2,1,-5,4] i = -2 => j = i+ 1 = 1 run to the end of number and check sum 
         * but i think.. i have a bester solution
         * just one loop and create max and sum and we need to check total i and previous i
         * example [-2,1,-3,4,-1,2,1,-5,4]  
         * if i = 1 , we compare nums[1] vs sum[-2,1] => we choose num[1] because num[1] > sum 
         * and we compare sum with max =>> max = sum in this case
         * do you understand my solution? and do you want to me inprove my solution or implementation?
         *                                          
         */
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length < 2) return nums[nums.Length - 1];

            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < nums[i])
                    sum = nums[i];
                if (sum > max)
                    max = sum;
            }
            return max;
        }

        //###############################################################
        //Khong biet bai nao
        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                if (stack.Count > 0 && stack.Peek() == head.val)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(head.val);
                    head = head.next;
                }
            }
            if (stack.Count > 0) return false;
            return true;
        }
        public static ListNode GetMid(ListNode head)
        {
            ListNode low = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                low = low.next;
                fast = fast.next.next;
            }
            return low;
        }

        /*basic-calculator-ii
         * using stack : add number if cal * or / we cal first to add stack
         * 
         */
        public static bool JudgeSquareSum(int c)
        {
            for (int a = 0; a * a <= c / 2; a++)
            {
                int a2 = a * a;
                int b2 = c - a2;

                if (b2 == 1 || b2 == 0 || IsPowofTwo(b2))
                {
                    return true;
                }
            }

            return false;
        }
        private static bool IsPowofTwo(int num)
        {
            //if (num == 0 || num == 1 || num == 2) return false;
            return (num & (num - 1)) == 0;
        }
        private bool IsPerfectSquare(int num)
        {
            checked
            {
                int left = 1;
                int right = num;

                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    long lMid = mid;
                    long sqr = lMid * lMid;

                    if (sqr == num)
                    {
                        return true;
                    }

                    if (sqr < num)
                    {
                        left = mid + 1;
                        continue;
                    }

                    right = mid;
                }

                long lLeft = left;
                return (lLeft * lLeft) == (long)num;

            }
        }
        //roman-to-integer
        public int RomanToInt(string s)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("I", 1);
            dic.Add("V", 5);
            dic.Add("X", 10);
            dic.Add("L", 50);
            dic.Add("C", 100);
            dic.Add("D", 500);
            dic.Add("M", 1000);
            int result = 0;
            string firstChar = "";
            while (s.Length > 0)
            {
                string charString = s.Substring(0, 1);
                if (firstChar == "I" && (charString == "V" || charString == "X"))
                {
                    result += dic[charString] - dic[firstChar];
                    firstChar = "";
                    s = s.Substring(1);
                    continue;
                }
                else if (firstChar == "X" && (charString == "L" || charString == "C"))
                {
                    result += dic[charString] - dic[firstChar];
                    firstChar = "";
                    s = s.Substring(1);
                    continue;
                }
                else if (firstChar == "C" && (charString == "D" || charString == "M"))
                {
                    result += dic[charString] - dic[firstChar];
                    firstChar = "";
                    s = s.Substring(1);
                    continue;
                }

                if ((charString == "I" || charString == "X" || charString == "C") && s.Length > 1)
                {
                    if (firstChar != "") result += dic[firstChar];
                    firstChar = charString;
                    s = s.Substring(1);
                    continue;
                }
                if (firstChar != "")
                {
                    result += dic[firstChar];
                    firstChar = "";
                }
                s = s.Substring(1);
                result += dic[charString];
            }
            return result;
        }

        public static bool judgeSquareSum(int c)
        {
            for (long a = 0; a * a <= c; a++)
            {
                int b = c - (int)(a * a);
                if (binary_search(0, b, b))
                    return true;
            }
            return false;
        }
        public static bool binary_search(long s, long e, int n)
        {
            if (s > e)
                return false;
            long mid = s + (e - s) / 2;
            if (mid * mid == n)
                return true;
            if (mid * mid > n)
                return binary_search(s, mid - 1, n);
            return binary_search(mid + 1, e, n);
        }
        //3. Longest Substring Without Repeating Characters
        //public static int LengthOfLongestSubstring(string s)
        //{
        //    int result = 0;
        //    int maxLength = 0;
        //    int count = 0;
        //    var dic = new Dictionary<char, int>();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (!dic.ContainsKey(s[i]))
        //        {
        //            dic.Add(s[i], i + 1);
        //            maxLength++;
        //            if (result < maxLength)
        //                result = maxLength;
        //        }
        //        else
        //        {
        //            maxLength++;
        //            maxLength = maxLength - dic[s[i]] + count; //bbtablud"
        //            foreach (var item in dic.Where(x => x.Value < dic[s[i]]))
        //            {
        //                dic.Remove(item.Key);
        //                count++;
        //            }
        //            count++;
        //            dic[s[i]] = i + 1;
        //        }
        //    }
        //    return result;
        //}


        //Addtion
        //length-of-last-word
        public int LengthOfLastWord(string s)
        {
            /*length-of-last-word
             * s consists of only English letters and spaces ' '. so i use trim to cut ' ' in the end and
             * to array => get length of last in array
             */
            var listString = s.Trim().Split(" ");
            return listString[listString.Length - 1].Length;
        }
        
    }
}
