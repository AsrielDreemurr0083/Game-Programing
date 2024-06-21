using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
namespace Program
{       
    public class HashTable<KEY,VALUE>
    {

        private class Node
        {
            public KEY key;
            public VALUE value;

            public Node next;
        }

        private class Bucket
        {
            public int count;
            public Node head;
        }
        private Bucket[] bucket;
        private readonly int arraySize;

        public HashTable()
        {
            arraySize = 6;
            bucket = new Bucket[arraySize];

            for(int i = 0; i < arraySize; i++)
            {
                bucket[i] = new Bucket();
            }
        }

        int HashFunction(KEY key)
        {
            return int.Parse(key.ToString()) % arraySize;
        }
        private Node CreateNode(KEY key, VALUE value)
        {
            Node newNode = new Node();

            newNode.key = key;
            newNode.value = value;
            newNode.next = null;
            return newNode;            
        }
        public void Insert(KEY key,VALUE value)
        {
            //해시 함수를 통해서 값을 받는 임시 변수
            
            int hashIndex = HashFunction(key);

            //새로운 노드를 생성   
            Node newNode = CreateNode(key, value);

            //노드가 1개라도 존재하지 않는다면
            if (bucket[hashIndex].count <= 0)
            {
                //1. bucket[hashIndex]의 head 포인터에 새로운 노드를 저장한다.
                bucket[hashIndex].head = newNode;
                bucket[hashIndex].count++;
            }
            else //노드가 1개라도 존재한다면
            {
                // 1. newNode의 next에 bucket[hashIndex]의 head 값을 저장
                newNode.next = bucket[hashIndex].head;
                // 2. bucket[hashIndex].head를 방금 생성한 노드의 주소를 가리키게 한다.
                bucket[hashIndex].head = newNode;
                // 3. bucket[hashIndex]의 count 변수의 값을 증가시킨다.
                bucket[hashIndex].count++;
            }  
        }

        public void Show()
        {
            for(int i = 0; i < arraySize;i++)
            {
                Node currentNode = bucket[i].head;
                while(currentNode != null)
                {
                    Console.Write("[" + i + "]" + "KEY : " + currentNode.key + "VALUE : " + currentNode.value + " ");
                    currentNode = currentNode.next;
                }
                Console.WriteLine();
            }
        }

    }




    internal class Program
    {        

        
        static void Main(string[] args)
        {
            HashTable<int,string> hashTable = new HashTable<int,string>();

            hashTable.Insert(10, "Diamond");
            hashTable.Insert(6, "Ruby");
            hashTable.Insert(4, "Sapphire");

            hashTable.Show();
        }
    }
}
