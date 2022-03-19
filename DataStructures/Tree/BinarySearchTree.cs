// this tree only works for unique integer values
namespace DataStructures.Tree
{
    public class BinarySearchTree { 
        class Node
        {
            public int Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
        }

        private Node root=null;

        /// <summary>
        ///     Insert a non repeated value into the tree
        /// </summary>
        /// <param name="item"></param>

        public void Insert(int item)
        {
            var node = new Node() { Value = item };
            if (root==null)
            {
                root = node;
                return;
            }
            var current = root;
            while(true)
            {
                if(current.Value>item)
                {
                    if(current.LeftChild==null)
                    {
                        current.LeftChild = node;
                        break;
                    }
                    current = current.LeftChild;
                }
                else
                {
                    if(current.RightChild==null)
                    {
                        current.RightChild = node;
                        break; 
                    }
                    current = current.RightChild;
                }
            }
        }


        public bool Find(int value)
        {
            if (root == null)
            {
                return false;
            }
            var current = root;

            while (current!=null)
            {
                if(value>current.Value)
                {
                    current = current.RightChild;
                }
                else if (value<current.Value)
                {
                    current = current.LeftChild;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
