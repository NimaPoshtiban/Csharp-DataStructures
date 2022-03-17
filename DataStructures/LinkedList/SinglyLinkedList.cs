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
        public int Length { get; set; } = 0;

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
            Length++;
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
            Length++;
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
            for (int i = 0; i < Length; i++)
            {
                if (node.Value.Equals(value))
                {
                    return i;
                }
                node = node.Next;
                if (node == null)
                {
                    return -1;
                }
                if (node.Value.Equals(value))
                {
                    return ++i;
                }
            }
            return -1;
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
                Length++;
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