using System.Collections;
using System.Collections.Generic;
using System.Drawing;
namespace Program
{   
    public class CircleLinkedList<T>
    {
        private class Node
        {
           public T data;
           public Node next;
        }

        private Node head; 
        private int size;

        public CircleLinkedList()
        {
            size = 0;
            head = null;
        }

        public void PushBack(T data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (head == null)
            {
                head = newNode;

                newNode.next = head;
            }
            else
            {
                newNode.next = head.next;
                head.next = newNode;
                head = newNode;
            }
            
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CircleLinkedList<int> circleLinkedList = new CircleLinkedList<int>();

            circleLinkedList.PushBack(10);
            circleLinkedList.PushBack(20);
            circleLinkedList.PushBack(30);


        }
    }
}
