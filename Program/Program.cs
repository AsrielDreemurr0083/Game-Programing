using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
namespace Program
{   
    public class BinarySearchTree<T>
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
        }
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        Node CreateNode(int data)
        {
            //1. 새로운 노드를 생성
            Node Node = new Node();
            //2. 새로운 노드의 data를 초기화
            Node.data = data;
            //3. 새로운 노드의 left 값을 초기화
            Node.left = null;
            //4. 새로운 노드의 right 값을 초기화
            Node.right = null;
            //5. 새로운 노드를 반환
            return Node;
        }

        public void Insert(int data)
        {
            if(root == null)
            {
                root = CreateNode(data);
            }
            else
            {
                Node currentNode = root;

                while(currentNode != null)
                {
                    if(currentNode.data > data)
                    {
                        if(currentNode.left == null)
                        {
                            currentNode.left = CreateNode(data);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else
                    {
                        if(currentNode.right == null)
                        {
                            currentNode.right = CreateNode(data);
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            }
        }

        public bool Find(int data)
        {
            Node currentNode = root;
            while(currentNode != null)
            {
                if(currentNode.data == data)
                {
                    return true;
                }
                else
                {
                    if(currentNode.data > data)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }
            return false;
        }

        //public bool Find(int data)
        //{
        //    Node currentNode = root;
        //    while(currentNode != null)
        //    {
        //        if(data == currentNode.data)
        //        {
        //            return true;
        //        }
        //        else if(data < currentNode.data) 
        //        {
        //            currentNode = currentNode.left;
        //        }
        //        else
        //        {
        //            currentNode = currentNode.right;
        //        }
        //    }
        //    return false;
        //}

        public void Inorder(Node root)
        {
            if(root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }

       //public void Inorder(Node root)
       //{
       //    
       //}

        //public void Insert(int data)
        //{
        //    if(root == null)
        //    {
        //        Console.WriteLine("Root is Empty");
        //        root = CreateNode(data);
        //        return;
        //    }
        //
        //    Node currentNode = root;
        //    while (true)
        //    {
        //       if(data < currentNode.data)
        //       {
        //           if(currentNode.left == null)
        //           {
        //               currentNode.left = CreateNode(data);
        //               break;
        //           }
        //           currentNode = currentNode.left;
        //       }
        //       else if(data > currentNode.data)
        //       {
        //           if(currentNode.right == null)
        //           {
        //               currentNode.right = CreateNode(data);
        //               break;
        //           }
        //           currentNode = currentNode.right;
        //       }
        //       else
        //       {
        //           break;
        //       }
        //    }
        //}
        
    } 

   internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            
            binarySearchTree.Insert(10);
            binarySearchTree.Insert(7);
            binarySearchTree.Insert(12);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(9);

            Console.WriteLine("binarySearchTree Find(7) : " + binarySearchTree.Find(7));
            Console.WriteLine("binarySearchTree Find(11) : " + binarySearchTree.Find(11));

            Console.WriteLine();

            binarySearchTree.Inorder(binarySearchTree.root);
        }
    }
}
