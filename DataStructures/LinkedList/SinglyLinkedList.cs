namespace DataStructures.LinkedList
{
    public class SinglyLinkedList<T>
    {
        class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
        }

        private Node first;
        private Node last;

        /// <summary>
        ///     Adds the elements to the end of the list (O(1))
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(T value)
        {
            var node = new Node() { Value = value };
            Initializer(node);
            var temp = first;
            first = node;
            first.Next = temp;
        }

        /// <summary>
        ///     Adds the elements to the end of the list (O(1))
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            var node = new Node() { Value = value };
            Initializer(node);
            last.Next = node;
            last = node;
        }

        /// <summary>
        ///  returns the indexOf the item
        ///  if item does'nt exist in the list returns -1
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        ///     item does exist -> index of the item
        ///     item does not exist -> -1
        /// </returns>
        public int IndexOf(T value)
        {
            if (IsEmpty()) return -1;
            var node = first;
            int index = 0;
            while (node!=null)
            {
                if(node.Value.Equals(value))
                {
                    return index;
                }
                index++;
                node = node.Next;
            }
            return -1;
        }

        public bool Contains(T value)
        {
            if (IsEmpty())
            {
                return false;
            }
            if(IndexOf(value)==-1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        ///     Initilizes the list when it's empty
        /// </summary>
        /// <param name="node"></param>
        private void Initializer(Node node)
        {
            if (IsEmpty())
            {
                first = last = node;
            }
        }

        /// <summary>
        ///  check to see if the list is empty
        /// </summary>
        /// <returns></returns>
        private bool IsEmpty()
        {
            return first == null;
        }
    }
}