using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Given a binary tree, find its minimum depth.

// The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

namespace LeetSharp
{
    [TestClass]
    public class Q111_MinimumDepthofBinaryTree
    {
        public int MinDepth(BinaryTree root)
        {
            return -1;
        }

        public string SolveQuestion(string input)
        {
            return MinDepth(input.ToBinaryTree()).ToString();
        }

        [TestMethod]
        public void Q111_Small()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
        [TestMethod]
        public void Q111_Large()
        {
            TestHelper.Run(s => SolveQuestion(s));
        }
    }
}
