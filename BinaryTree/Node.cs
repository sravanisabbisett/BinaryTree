using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node<K> where K:IComparable
    {
        public K key;
        public Node<K> left;
        public Node<K> right;

        public Node(K key)
        {
            this.key = key;
            this.left = null;
            this.right = null;
        }
    }
}
