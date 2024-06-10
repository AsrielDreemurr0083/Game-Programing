namespace Program
{
    public class SingleLinkedList<T>
    {       
        private class Node
        {
            public T data;
            public Node next;
        }

        private Node head;
        private int size;

        public SingleLinkedList()
        {
            size = 0;
            head = null;
        }

        public void PushFront(T data)
        {
            if(head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node newNode = new Node();
                newNode.data = data;
                newNode.next = head;

                head = newNode;
            }

            size++;

        }

        public void Show()
        {
            Node currentNode = head;

            while(currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }

        public void Size()
        {
            //size = 
        }
    }

    
    
    

    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();

            singleLinkedList.PushFront(30);
            singleLinkedList.PushFront(20);
            singleLinkedList.PushFront(10);

            //Console.Write("singleLinkedList의 size : " + singleLinkedList.Size());

            singleLinkedList.Show();
        }
    }
}
