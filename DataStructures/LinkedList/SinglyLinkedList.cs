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
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                node.Next = first;
                first = node;
            }
        }

        /// <summary>
        ///     Adds the elements to the end of the list (O(1))
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            var node = new Node() { Value = value };
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.Next = node;
                last = node;
            }
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
            var current = first;
            int index = 0;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
        /// <summary>
        ///  check to see if the element exists in the list (O(n))
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (IndexOf(value) == -1)
            {
                return false;
            }
            return true;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            if (first == last)
            {
                first = last = null;
            }
            var node = first.Next;
            first.Next = null;
            first = node;
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