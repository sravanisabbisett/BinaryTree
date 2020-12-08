using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree<K> where K:IComparable
    {
        public Node<K> root;

        /// <summary>
        /// Adds the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        public void Add(K key)
        {
            this.root = this.AddRecursively(root,key);
        }

        /// <summary>
        /// Adds the recursively.
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public Node<K> AddRecursively(Node<K> current,K key)
        {
            if (current == null)
                return new Node<K>(key);
            int compareResult = key.CompareTo(current.key);
            if (compareResult == 0)
                return current;
            if (compareResult < 0)
                current.left = AddRecursively(current.left, key);
            if (compareResult > 0)
                current.right = AddRecursively(current.right, key);
            return current;
            
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return GetSizeRecursively(root);
        }

        /// <summary>
        /// Gets the size recursively.
        /// </summary>
        /// <param name="current">The current.</param>
        /// <returns></returns>
        public int GetSizeRecursively(Node<K> current)
        {
            return current == null ? 0 : 1 + this.GetSizeRecursively(current.left) +
                                     this.GetSizeRecursively(current.right);
        }

        /// <summary>
        /// Searches the recursively.
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public bool SearchRecursively(Node<K> current,K key)
        {
            if (current == null)
                return false;
            int compareResult = key.CompareTo(current.key);
            if (compareResult == 0)
                return true;
            if (compareResult < 0)
                return SearchRecursively(current.left, key);
            else
                return SearchRecursively(current.right, key);

        }

        /// <summary>
        /// Searches the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public bool Search(K key)
        {
            bool isPresent = SearchRecursively(root, key);
            return isPresent;
        }
    }
}
