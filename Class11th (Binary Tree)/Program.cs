namespace Class11th__Binary_Tree_
{
    public class Node
    {
        public int data;

        public Node right;
        public Node left;
    }

    internal class Program
    {
        static Node CreateNode(int data, Node left, Node right)
        {
            //1. 새로운 노드를 생성한다
            Node newNode = new Node();

            //2. 새로운 노드의 data값을 저장한다.
            newNode.data = data;

            //3. 새로운 노드의 left 값을 저장한다.
            newNode.left = left;

            //4. 새로운 노드의 right 값을 저장한다
            newNode.right = right;

            //5. 새로운 노드를 반환한다.

            return newNode;
        }

        //전위순회
        //1. root Node를 방문합니다.
        //2. 왼쪽 자식 노드를 전위 순회한다.
        //3. 오른쪽 자식 노드를 전위 순회한다.

        static void Preorder(Node root)
        {
            //if(root == null)            
            //    return;
            //Console.Write(root.data + " ");
            //
            //Preorder(root.left);
            //
            //Preorder(root.right);

            if (root != null)
            {
                Console.Write(root.data + " ");
                Preorder(root.left);
                Preorder(root.right);
            }
        }

        static void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.data + " ");
                Inorder(root.right);
            }
        }

        static void Postorder(Node root)
        {
            if (root != null)
            {
                Postorder(root.left);
                Postorder(root.right);
                Console.Write(root.data + " ");
            }
        }


        static void Main(string[] args)
        {
            //Node leaf1 = CreateNode(4, null, null);
            //Node leaf2 = CreateNode(5, null, null);
            //Node branch1 = CreateNode(2, leaf1, leaf2);
            //
            //Node leaf3 = CreateNode(6, null, null);
            //Node leaf4 = CreateNode(7, null, null);
            //Node branch2 = CreateNode(3, leaf3, leaf4);
            //
            //Node root = CreateNode(1, branch1, branch2);

            Node node7 = CreateNode(7, null, null);
            Node node6 = CreateNode(6, null, null);
            Node node5 = CreateNode(5, null, null);
            Node node4 = CreateNode(4, null, null);

            Node node3 = CreateNode(3, node6, node7);
            Node node2 = CreateNode(2, node4, node5);

            Node node1 = CreateNode(1, node2, node3);

            //Node root = CreateNode(1, node2, node3);

            //전위순회
            //Preorder(root);

            //Preorder(node1);

            //중위순회
            //Inorder(node1);

            //후위순회
            Postorder(node1);
        }
    }
}
