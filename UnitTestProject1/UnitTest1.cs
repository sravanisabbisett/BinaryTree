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

        [TestMethod]
        public void Adding13ElementsInBinaryTreeShouldReturnSize13()
        {
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);
            tree.Add(22);
            tree.Add(40);
            tree.Add(60);
            tree.Add(95);
            tree.Add(11);
            tree.Add(3);
            tree.Add(16);
            tree.Add(65);
            tree.Add(63);
            tree.Add(67);
            int size = tree.Size();
            Assert.AreEqual(13, size);
        }
    }
}
