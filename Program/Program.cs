using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
namespace Program
{   
    public class AdjacencyList<T>
    {
        public class Node
        {
            T data;
            Node next;

            public Node(T data, Node link = null)
            {
                this.data = data;
                next = link;
            }
        }

        private int size;//정점의 개수
        private int arraySize;//인접리스트의 크기

        private T[] vertex;//정점의 집합
        private Node[] list;//인접 리스트

        public AdjacencyList()
        {
            size = 0;
            arraySize = 10;
            vertex = new T[arraySize];
            list = new Node[arraySize];
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인접리스트
            //그래프의 각 정점에 인접한 정점들을 연결리스트로
            //표현하는 방법이다.

            //장점
            // 그래프의 모든 간선의 수를 O(V+E)로 표현할 수 있다.

            //단점
            // 두 정점을 연결하는 간선을 조회하거나 정점의 차수를 알기 위해서
            // 정점의 인접 리스트를 모두 탐색해야 하므로,
            // 정점의 차수만큼의 시간이 필요하다.

            //class AdjacencyList
            #endregion
        }
    }
}
