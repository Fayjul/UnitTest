namespace MyStackApp
{
    public class MyStack<T>
    {
        private List<T> _elements;
        public MyStack()
        {
            _elements = new List<T>();
        }

        public void Push(T item)
        {
            _elements.Add(item);
        }

        public T Pop()
        {
            int position = _elements.Count;
            if (position == 0)
            {
                throw new InvalidOperationException("Stack underflow");
            }

            T data = _elements[position-1];
            _elements.RemoveAt(position-1);
            return data;
        }

        public int Size()
        {
            return _elements.Count;
        }

        public object Top()
        {
            int position = _elements.Count;
            if (position == 0)
            {
                throw new InvalidOperationException("Stack underflow");
            }

            return _elements[position - 1];
        }
    }
}
