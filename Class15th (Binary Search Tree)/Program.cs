namespace Class15th__Binary_Search_Tree_
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
            if (root == null)
            {
                root = CreateNode(data);
            }
            else
            {
                Node currentNode = root;

                while (currentNode != null)
                {
                    if (currentNode.data > data)
                    {
                        if (currentNode.left == null)
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
                        if (currentNode.right == null)
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
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return true;
                }
                else
                {
                    if (currentNode.data > data)
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
        #region Remove
        //public bool Remove(int data)
        //{
        //    Node parent = null;
        //    Node currentNode = root;
        //
        //    // 삭제할 노드 찾기
        //    while (currentNode != null && currentNode.data != data)
        //    {
        //        parent = currentNode;
        //        if (data < currentNode.data)
        //        {
        //            currentNode = currentNode.left;
        //        }
        //        else
        //        {
        //            currentNode = currentNode.right;
        //        }
        //    }
        //
        //    // 노드를 찾지 못한 경우
        //    if (currentNode == null)
        //    {
        //        return false;
        //    }
        //
        //    // 리프 노드가 아닌 경우 삭제하지 않음
        //    if (currentNode.left != null || currentNode.right != null)
        //    {
        //        return false;
        //    }
        //
        //    // 리프 노드 삭제
        //    if (parent == null)
        //    {
        //        root = null; // 루트 노드인 경우
        //    }
        //    else
        //    {
        //        if (parent.left == currentNode)
        //        {
        //            parent.left = null;
        //        }
        //        else
        //        {
        //            parent.right = null;
        //        }
        //    }
        //
        //    return true;
        //}
        #endregion

        public void Remove(int data)
        {
            Node currentNode = root;
            Node parentNode = null;

            if (currentNode == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            else
            {
                while (currentNode.data != data)
                {
                    parentNode = currentNode;
                    if (currentNode.data > data)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }

            if (currentNode == null)
            {
                Console.WriteLine("Data not found is the Binary Search Tree");
            }
            else
            {
                if (currentNode.left == null && currentNode.right == null)
                {
                    if (parentNode != null)
                    {
                        if (parentNode.left == currentNode)
                        {
                            parentNode.left = null;
                        }
                        else
                        {
                            parentNode.right = null;
                        }
                    }
                    else
                    {
                        root = null;
                    }
                }
                else if (currentNode.left == null || currentNode.right == null)
                {
                    Node childNode = null;
                    if (currentNode.left != null)
                    {
                        childNode = currentNode.left;
                    }
                    else
                    {
                        childNode = currentNode.right;
                    }

                    if (parentNode != null)
                    {
                        if (parentNode.left == currentNode)
                        {
                            parentNode.left = childNode;
                        }
                        else
                        {
                            parentNode.right = childNode;
                        }
                    }
                }
                else
                {
                    Node findNode = currentNode.right;
                    Node traceNode = findNode;

                    while (findNode.left != null)
                    {
                        traceNode = findNode;
                        findNode = findNode.left;
                    }

                    currentNode.data = findNode.data;

                    traceNode.left = findNode.right;
                }
            }

        }


        public void Inorder(Node root)
        {
            if (root != null)
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
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(19);
            binarySearchTree.Insert(14);
            binarySearchTree.Insert(23);
            binarySearchTree.Insert(21);


            //Console.WriteLine("binarySearchTree Find(7) : " + binarySearchTree.Find(7));
            //Console.WriteLine("binarySearchTree Find(11) : " + binarySearchTree.Find(11));

            //Console.WriteLine();
            binarySearchTree.Remove(19);

            binarySearchTree.Inorder(binarySearchTree.root);


            //1.자식 노드가 없을때 
            //2.부모를 저장할 수 있는 방법

            //15를 삭제하고자 할경우 current는 15를 가리켜야함
        }
    }
}
