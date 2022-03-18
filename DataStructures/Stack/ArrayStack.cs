using System.Text;

namespace DataStructures.Stack
{
    public class ArrayStack<T>
    {
        private readonly int _size;
        private T[] _array;
        public ArrayStack(int size)
        {
            _size = size;
            _array = new T[size];
        }
        public int Count { get; set; } = 0;

        public bool IsEmpty => _array.Length == 0;


        /// <summary>
        ///  add the item to the top of the stack
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="StackOverflowException"></exception>
        public void Push(T item)
        {
            if (Count == _size)
            {
                throw new StackOverflowException("Stack has reached it's maximum size");
            }
            _array[Count++] = item;
        }

        /// <summary>
        /// return the last item then remove it
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            var topItem = _array[--Count];
            _array[Count] = default(T);
            return topItem;
        }

        /// <summary>
        /// return the last item
        /// </summary>
        public T Pick()
        {
            if (IsEmpty)
            {
                return default(T);
            }
            return _array[Count - 1];
        }

        public T this[int index] { get { return _array[index]; } }

        public override string ToString()
        {
            var text = new StringBuilder("From Buttom to Top:\n");
            for (int i = 0; i < Count; i++)
            {
                text.Append($"{_array[i]}\n");
            }
            return text.ToString();
        }
    }
}
