namespace Program
{
    public class DoubleLinkedList<T>
    {
        public class Node
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
            size++;
        }

        public void PushFront(T data)
        {
            //Node newNode = new Node();
            //newNode.data = data;
            //
            //if (head == null)
            //{
            //    head = newNode;
            //    tail = newNode;
            //
            //    newNode.next = null;
            //    newNode.previous = null;
            //}
            //else
            //{
            //    newNode.next = head;
            //    head.previous = newNode;
            //
            //    head = newNode;
            //    newNode.previous = null;
            //}
            //size++;

            if(head == null)
            {
                head = new Node();
                tail = head;

                head.data = data;
                head.next = null;
                head.previous = null;
            }
            else
            {
                Node newNode = new Node();

                newNode.next = head;

                head.previous = newNode;
                head = newNode;

                newNode.data = data;
                newNode.previous = null;
            }
            size++;
        }

        public int Size()
        {
            return size;
        }

        public void RemoveBack()
        {           
            if (tail == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                if (head == tail)
                {                    
                    tail = tail.next;
                    head = tail;
                }
                else
                {
                    tail.previous.next = null;
                    tail = tail.previous;
                }
                size--;
                
            }
        }

        public void RemoveFront()
        {
            //if (head == null)
            //{
            //    Console.WriteLine("LinkedList is Empty");
            //}
            //else
            //{
            //    if(head == tail)
            //    {
            //        head = head.previous;
            //        tail = head;
            //    }
            //    else
            //    {
            //        head.next.previous = null;
            //        head = head.next;
            //    }
            //    size--;
            //}

            //정답
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                if(head == tail)
                {
                    head = head.previous;
                    tail = head;
                }
                else
                {
                    head.next.previous = null;
                    head = head.next;
                }
                size--;
            }
        }

        public Node First()
        {
            return head;
        }
        public Node Last()
        {
            return tail;
        }

        void AddAfter(Node position, T data)
        {
            if(head.next == null)
            {
                head.next = position;
            }
        }

        public void Show()
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int> ();
            
            

            doubleLinkedList.PushBack(10);            
            doubleLinkedList.PushBack(20);            
            doubleLinkedList.PushBack(30);
            doubleLinkedList.PushBack(40);

            Console.WriteLine("DoubleLinkedList의 size : " + doubleLinkedList.Size());
            
            doubleLinkedList.Show();



        }
    }
}
