using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree<K> where K:IComparable
    {
        public Node<K> root;

        public void Add(K key)
        {
            this.root = this.AddRecursively(root,key);
        }

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

        public int Size()
        {
            return GetSizeRecursively(root);
        }

        public int GetSizeRecursively(Node<K> current)
        {
            return current == null ? 0 : 1 + this.GetSizeRecursively(current.left) +
                                     this.GetSizeRecursively(current.right);
        }
    }
}
