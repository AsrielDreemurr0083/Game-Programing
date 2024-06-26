namespace Class12th__Heap_
{
    public class Heap
    {
        public int arraySize;
        public int size;
        public int[] array;

        public Heap()
        {
            arraySize = 8;
            size = 0;
            array = new int[arraySize];
        }
        //public void Insert(int data)
        //{
        //    if (size + 1 == arraySize)
        //    {
        //        Resize();
        //    }
        //
        //    size++;
        //    int child = size;
        //    int parent = child / 2;
        //
        //    array[child] = data;
        //
        //    for (int i = parent; i > 0; i--)
        //    {
        //        if (array[child] > array[i])
        //        {
        //            Swap(child, i);
        //            child = i;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //}
        //private void Swap(int i, int j)
        //{
        //    int temp = array[i];
        //    array[i] = array[j];
        //    array[j] = temp;
        //}
        //private void Resize()
        //{
        //    arraySize *= 2;
        //    int[] newArray = new int[arraySize];
        //    Array.Copy(array, newArray, size + 1);
        //    array = newArray;
        //}

        private void Swap(ref int x, ref int y)
        {
            int temporary = x;
            x = y;
            y = temporary;
        }

        public void Insert(int data)
        {
            if (size >= arraySize - 1)
            {
                Console.WriteLine("Heap is Full");
            }
            else
            {
                array[++size] = data;

                int child = size;
                int parent = size / 2;

                while (child > 1)
                {
                    if (array[child] > array[parent])
                    {
                        Swap(ref array[child], ref array[parent]);
                    }
                    child = parent;
                    parent = child / 2;
                }
            }
        }

        public int Remove()
        {
            //1. Heap이 비어있다면 ErrorCode를 반환
            //2. 임시 변수를 생성한 다음 array[1]을 저장

            //if(size == 0)
            //{
            //    Console.WriteLine("Heap is Empty");
            //}
            //
            //int removeFirst = array[1];
            //
            //array[1] = array[size];
            //size--;
            //
            //int parent = 1;
            //while (true)
            //{
            //    int leftChild = 2 * parent;
            //    int rightChild = 2 * parent + 1;
            //    int largest = parent;
            //
            //    // 왼쪽 자식이 더 크면 largest 갱신
            //    if (leftChild <= size && array[leftChild] > array[largest])
            //        largest = leftChild;
            //
            //    // 오른쪽 자식이 더 크면 largest 갱신
            //    if (rightChild <= size && array[rightChild] > array[largest])
            //        largest = rightChild;
            //
            //    // largest가 변경되지 않았다면 힙 속성 복구 완료
            //    if (largest == parent)
            //        break;
            //
            //    // parent와 largest 교환
            //    Swap(ref array[parent], ref array[largest]);
            //    parent = largest;
            //}
            //
            //return removeFirst;

            if (size <= 0)
            {
                //1. Heap이 비어있다면 Error 코드를 출력
                Console.WriteLine("Heap is Empty");
                return -9999;
            }

            //2. 임시 변수에 array[1] 값을 보관
            int result = array[1];

            //3. size로 가리키는 배열의 값을 첫 번째 원소에 넣어준다.
            array[1] = array[size];

            //4. size로 가리키는 배열의 값을 초기화
            array[size] = 0;

            //5. size의 값을 감소
            size--;

            int parent = 1;
            //정답
            while (parent * 2 <= size)
            {
                int child = parent * 2;
                //왼쪽자식 노드보다 오른쪽 자식 노드가 더 클 경우
                if (array[child] < array[child + 1])
                {
                    child++;
                }

                //부모 노드의 key값이 자식 노드의 key값 보다 크다면
                //반복문을 종료
                if (array[child] < array[parent])
                {
                    break;
                }
                Swap(ref array[parent], ref array[child]);
                parent = child;
            }
            return result;
            //while (true)
            //{
            //    int leftChild = parent * 2;
            //    int rightChild = parent * 2 + 1;
            //    int largest = parent;
            //
            //
            //    if (leftChild <= size && array[leftChild] > array[largest])
            //    {
            //        largest = leftChild;
            //    }
            //    if (rightChild <= size && array[rightChild] > array[largest])
            //    {
            //        largest = rightChild;
            //    }
            //
            //    if(largest == parent)
            //    {
            //        break;
            //    }
            //    Swap(ref array[parent], ref array[largest]); 
            //    parent = largest; 
            //}
            //return result;
        }



        public void Show()
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            // 0번째 인덱스는 비워둔다
            Heap heap = new Heap();

            heap.Insert(5); //[5]
            heap.Insert(7); //[7][5]
            heap.Insert(2); //[7][5][2]
            heap.Insert(10);//[10][7][2][5]

            Console.WriteLine("Top : " + heap.Remove());
            //Console.WriteLine("Top : " + heap.Remove());
            //Console.WriteLine("Top : " + heap.Remove());
            //Console.WriteLine("Top : " + heap.Remove());
            //Console.WriteLine("Top : " + heap.Remove());
            //heap.Remove();

            heap.Show();
        }
    }
}

