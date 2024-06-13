namespace Class2th__Double_Linked_List_
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

            if (tail == null)
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

            if (head == null)
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
                if (head == tail)
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

        public void AddAfter(Node position, T data)
        {
            if (position == null)
            {
                Console.WriteLine("Node cannot be Created");
                return;
            }


            if (position.next == null)
            {
                PushBack(data);
            }
            else
            {
                Node previousNode = position;
                Node nextNode = position.next;

                Node newNode = new Node();
                newNode.data = data;

                previousNode.next = newNode;
                nextNode.previous = newNode;

                newNode.previous = previousNode;
                newNode.next = nextNode;

                size++;
            }
        }

        public bool Find(T data)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.data.ToString() == data.ToString())
                {
                    return true;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }
            return false;
        }

        public void Remove(T data)
        {
            //정답
            Node currentNode = head;

            if (Find(data) == false)
            {
                Console.WriteLine("No data Exists");
            }
            else
            {
                while (currentNode != null)
                {
                    if (currentNode.data.ToString() == data.ToString())
                    {
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.next;
                    }
                }
                if (head == tail)
                {
                    head = null;
                    tail = null;

                    size--;
                }
                else if (currentNode.next == null)
                {
                    RemoveBack();
                }
                else if (currentNode.previous == null)
                {
                    RemoveFront();
                }
                else
                {
                    Node nextNode = currentNode.next;
                    Node previousNode = currentNode.previous;

                    previousNode.next = nextNode;
                    currentNode.previous = previousNode;
                    size--;
                }

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
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();



            doubleLinkedList.PushFront(30);
            doubleLinkedList.PushFront(20);
            doubleLinkedList.PushFront(10);

            //doubleLinkedList.AddAfter(doubleLinkedList.First().next, 99);
            //doubleLinkedList.AddAfter(doubleLinkedList.Last(), 50);

            doubleLinkedList.Remove(40);

            Console.WriteLine(doubleLinkedList.Find(33));

            Console.WriteLine("DoubleLinkedList의 size : " + doubleLinkedList.Size());

            doubleLinkedList.Show();



        }
    }
}
