namespace Class4th
{
    public class Stack<T>
    {
        private int top;

        private readonly int arraySize;
        private T error;
        private T[] array;

        public Stack()
        {
            top = -1;
            arraySize = 5;

            array = new T[arraySize];
        }

        public void Push(T data)
        {
            if (top >= arraySize - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                array[++top] = data;
            }
        }

        public T Peek()
        {
            return array[++top];
        }

        public T Pop()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack is Empty");
                return error;
            }
            else
            {
                return array[--top];
            }
        }

        public bool Constains(T data)
        {
            for (int i = 0; i <= top; i++)
            {
                if (array[i].ToString() == data.ToString())
                {
                    return true;

                }
            }
            return false;
        }

    }
    internal class Program
    {
        //static bool CheckBracket(string content)
        //{
        //    if(content == null)
        //    {
        //        return false;
        //    }
        //    Stack<char> stack = new Stack<char>();
        //}



        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);


            Console.WriteLine("Stack의 Constains(30) : " + stack.Constains(99));

            Console.WriteLine("Stack의 Peek : " + stack.Pop());
            Console.WriteLine("Stack의 Peek : " + stack.Pop());
            Console.WriteLine("Stack의 Peek : " + stack.Pop());
            Console.WriteLine("Stack의 Peek : " + stack.Pop());


        }
    }
}

