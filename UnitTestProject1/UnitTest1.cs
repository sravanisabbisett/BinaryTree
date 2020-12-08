using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Tree<int> tree;

        public UnitTest1()
        {
            tree = new Tree<int>();
        }

        /// <summary>
        /// Addings the size of the three elements in binary tree should return.
        /// </summary>
        [TestMethod]
        public void AddingThreeElementsInBinaryTreeShouldReturnSize()
        {
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
            int size = tree.Size();
            Assert.AreEqual(3, size);
        }
    }
}
