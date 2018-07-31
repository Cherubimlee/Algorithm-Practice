using System;
using System.Collections.Generic;

namespace Leet
{
    public partial class Solution {
     HashSet<Tuple<int, int, int>> hashlist = new HashSet<Tuple<int, int, int>>(new TupleComparer());

        public IList<IList<int>> ThreeSum(int[] nums)
        {

            List<IList<int>> list = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                int target = -1 * nums[i];

                var dict = TwoSumPlus(nums, target, i + 1);

                list.AddRange(dict);

            }


            return list;
        }



        public List<IList<int>> TwoSumPlus(int[] nums, int target, int startIndex = 0)
        {
            Dictionary<int, int> dir = new Dictionary<int, int>();

            List<IList<int>> tuples = new List<IList<int>>();

            for (int i = startIndex; i < nums.Length; i++)
            {
                int key = target - nums[i];

                if (!dir.ContainsKey(key))
                {
                    dir[key] = i;
                }


            }

            for (int j = startIndex + 1; j < nums.Length; j++)
            {

                if (dir.ContainsKey(nums[j]))
                {
                    int i = dir[nums[j]];
                    if (i != j)
                    {
                        var ot = 0 - target;
                        Tuple<int, int, int> tuple = new Tuple<int, int, int>(ot, nums[i], nums[j]);
                        if (!hashlist.Contains(tuple))
                        {
                            hashlist.Add(tuple);
                            List<int> l = new List<int>();
                            l.Add(ot);
                            l.Add(nums[i]);
                            l.Add(nums[j]);
                            tuples.Add(l);
                        }
                    }
                }
            }

            return tuples;
        }

        class TupleComparer : EqualityComparer<Tuple<int, int, int>>
        {
            public override bool Equals(Tuple<int, int, int> s1, Tuple<int, int, int> s2)
            {
                if (s1.Item1 == s2.Item1 || s1.Item1 == s2.Item2 || s1.Item1 == s2.Item3)
                {
                    if (s1.Item2 == s2.Item1 || s1.Item2 == s2.Item2 || s1.Item2 == s2.Item3)
                    {

                        if (s1.Item3 == s2.Item1 || s1.Item3 == s2.Item2 || s1.Item3 == s2.Item3)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            public override int GetHashCode(Tuple<int, int, int> s)
            {
                return s.Item1.GetHashCode() ^ s.Item2.GetHashCode() ^ s.Item3.GetHashCode();
            }
        }
    }

}

