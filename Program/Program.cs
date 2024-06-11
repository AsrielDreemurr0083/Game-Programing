namespace Program
{
    public class DoubleLinkedList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
            public Node previous;
        }

        private int size;
        private Node head;
        private Node tail;
        

        public DoubleLinkedList()
        {
            size = 0;
            head = null;
            tail = null;
        }

        public void PushBack(T data)
        {
            Node newNode = new Node();

            if(tail == null)
            {
                head = newNode;
                tail = newNode;

                newNode.data = data;
                newNode.next = null;
                newNode.previous = null;
            }
            else
            {
                tail.next = newNode;
                newNode.previous = tail;

                tail = newNode;

                newNode.data = data;
                newNode.next = null;
            }
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
