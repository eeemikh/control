namespace task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
    public class MyStack<T>
    {
        public T[] array;
        public int top;
        public MyStack()
        {
            array = new T[0];
            top = -1;
        }

        public void Push(T item)
        {
            T[] newarray = new T[top + 2];
            Array.Copy(array, newarray, top + 1);
            newarray[top + 1] = item;
            array = newarray;
            top = top + 1;
        }

        public T Pop()
        {
            if (top == -1)
                throw new InvalidOperationException("Empty");

            T item = array[top];
            top = top - 1;
            T[] newarray = new T[top + 1];
            Array.Copy(array, newarray, top + 1);
            array = newarray;
            return item;
        }
    }
}