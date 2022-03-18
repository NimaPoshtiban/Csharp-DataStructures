using System.Text;

namespace DataStructures.Queue
{
    public class ArrayQueue<T>
    {
        private readonly int _capacity;
        private int front;
        private int rear;
        private T[] _array;
        public ArrayQueue(int capacity)
        {
            _capacity = capacity;
            _array = new T[capacity];
            front = rear = 0;
        }

        /// <summary>
        ///     Add item to the end of the Queue
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="Exception"></exception>
        public void EnQueue(T item)
        {
            if (IsFull)
            {
                throw new Exception("Queue is Full");
            }
            if (Count != 0)
            {
                rear++;
            }
            _array[Count++] = item;
        }

        /// <summary>
        ///     Dequeue the item fron Queue
        /// </summary>
        /// <returns>the front item</returns>
        /// <exception cref="Exception"></exception>
        public T DeQueue()
        {
            if (IsEmpty)
            {
                throw new Exception("Queue is Empty");
            }
            Count--;
            var firstItem = _array[front];
            _array[front++] = default(T);
            return firstItem;
        }


        /// <summary>
        ///     returns the front item
        /// </summary>
        /// <returns>The front item</returns>
        public T Peek()
        {
            return _array[front];
        }

        public bool IsEmpty => Count == 0;

        public bool IsFull => _capacity == Count;

        public int Count { get; set; } = 0;

        public T this[int index] => _array[index];

        public override string ToString()
        {
            var text = new StringBuilder("From front to rear:\n");
            if (Count == 0)
            {
                return "Queue is Empty";
            }
            for (int i = 0; i < Count; i++)
            {
                text.Append($"{_array[i]}\n");
            }
            return text.ToString();
        }
    }
}
