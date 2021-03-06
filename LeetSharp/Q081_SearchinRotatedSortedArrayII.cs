using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Follow up for "Search in Rotated Sorted Array": Q033
// What if duplicates are allowed?

// Would this affect the run-time complexity? How and why?

// Write a function to determine if a given target is in the array.

namespace LeetSharp
{
    [TestClass]
    public class Q081_SearchinRotatedSortedArrayII
    {
        public bool SearchRotated(int[] input, int target)
        {
            return false;
        }

        public string SolveQuestion(string input)
        {
            return SearchRotated(input.GetToken(0).ToIntArray(), input.GetToken(1).ToInt()).ToString().ToLower();
        }

        [TestMethod]
        public void Q081_Small()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
        [TestMethod]
        public void Q081_Large()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
    }
}
