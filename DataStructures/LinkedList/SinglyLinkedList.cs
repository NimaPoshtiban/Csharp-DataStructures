using System.Text;

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
        public int Length { get; set; }
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
            Length++;
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
            Length++;
        }

        /// <summary>
        ///  returns the indexOf the item
        ///  if item does'nt exist in the list returns -1
        ///  O(n)
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

        /// <summary>
        ///  removes the first item of the list (O(1))
        /// </summary>
        /// <exception cref="Exception"></exception>
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
            else
            {
                var node = first.Next;
                first.Next = null;
                first = node;
            }
            Length--;
        }

        /// <summary>
        /// removes the last item in the list
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var privious = GetPrivious(last);
                last = privious;
                last.Next = null;
            }
            Length--;
        }

        /// <summary>
        ///  Reverses the linkedList
        ///  Interview Question
        /// </summary>
        public void Reverse()
        {
            if (IsEmpty()) return;

            var previous = first;
            var current = first.Next;
            while (current != null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.Next = null;
            first = previous;
        }

        /// <summary>
        ///     Gets the Kth element from the end
        ///     Interview Question
        /// </summary>
        /// <param name="kth"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public T GetKthFromTheEnd(int kth)
        {
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }
            var firstNode = first;
            var secondNode = first;
            for (int i = 0; i < kth - 1; i++)
            {
                secondNode = secondNode.Next;
                if (secondNode == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            while (secondNode != null)
            {
                secondNode = secondNode.Next;
                if (secondNode != null)
                    firstNode = firstNode.Next;
            }
            return firstNode.Value;
        }

        /// <summary>
        ///  check to see if the list is empty
        /// </summary>
        /// <returns></returns>
        private bool IsEmpty()
        {
            return first == null;
        }

        /// <summary>
        ///  gets the privious node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private Node GetPrivious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.Next == node) return current;
                current = current.Next;
            }
            return null;
        }

        public override string ToString()
        {
            var text = new StringBuilder("");
            var current = first;
            for (int i = 0; i < Length; i++)
            {
                text.Append($"{current.Value} -> ");
                current = current.Next;
            }
            return text.ToString();
        }
    }
}