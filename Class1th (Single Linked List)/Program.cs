namespace Class1th__Single_Linked_List_
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
            if (head == null)
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

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }

        public int Size()
        {
            return size;
        }

        public void RemoveFront()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                head = head.next;
                size--;
            }
        }

        public void PushBack(T data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node currentNode = head;
                Node newNode = new Node();


                if (currentNode.next == null)
                {
                    newNode.data = data;
                    currentNode.next = newNode;
                }
                else
                {
                    while (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }

                    newNode.data = data;
                    currentNode.next = newNode;
                }

            }
            size++;
        }

        public void RemoveBack()
        {
            // Node node = null;
            // Node currentNode = head;
            //
            // while (currentNode.next != null)
            // {
            //     node = currentNode;
            //     currentNode = current.next;
            // }
            //
            // node.next = null;
            //
            // size--; 

            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                if (size == 1)
                {
                    head = null;
                }
                else
                {
                    Node currentNode = head;
                    Node previousNode = currentNode;
                    while (currentNode.next != null)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    previousNode.next = currentNode.next;
                }
                size--;
            }

        }

    }





    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();

            singleLinkedList.PushBack(30);
            singleLinkedList.PushBack(20);
            singleLinkedList.PushBack(10);


            singleLinkedList.RemoveBack();
            singleLinkedList.RemoveBack();
            singleLinkedList.RemoveBack();

            Console.WriteLine("singleLinkedList의 size : " + singleLinkedList.Size());

            singleLinkedList.Show();


        }
    }
}
