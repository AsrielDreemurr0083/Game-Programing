namespace Class9th__File_Input___Output_
{
    internal class Program
    {
        static void LoadText(string fileName)
        {
            StreamReader streamReader1 = new StreamReader("image1.txt");
            while (streamReader1.Peek() >= 0)
            {
                Console.WriteLine(streamReader1.ReadLine());
            }
            StreamReader streamReader2 = new StreamReader("images2.txt");
            while (streamReader2.Peek() >= 0)
            {
                Console.WriteLine(streamReader2.ReadLine());
            }
            StreamReader streamReader3 = new StreamReader("images3.txt");
            while (streamReader3.Peek() >= 0)
            {
                Console.WriteLine(streamReader3.ReadLine());
            }
            StreamReader streamReader4 = new StreamReader("images4.txt");
            while (streamReader4.Peek() >= 0)
            {
                Console.WriteLine(streamReader4.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            // File : 파일에 대한 생성, 복사, 이동 및 열기를 위한 클래스
            // FileInfo : 파일에 대한 생성, 복사, 이동 및 열기에 대한 속성
            // FileStream : 파일에 대한 스트림을 제공하여 동기 및 비동기 읽기/쓰기를 지원           

            //FileStream fileStream = File.Create("data.txt");

            //fileStream.Close();

            // StreamReader : 문자열에서 읽어오는 TextReade 구현한다.
            // StreamWriter : TextWriter를 구현하여 특정 인코딩을 스트림에 문자로 저장한다.

            //StreamWriter streamWriter = new StreamWriter("data.txt");
            //
            //streamWriter.WriteLine("HP 100");
            //streamWriter.WriteLine("Level 10");
            //streamWriter.WriteLine("Name Warrior");
            //
            //streamWriter.Close();

            //StreamReader streamReader = new StreamReader("images4.txt");
            //while (streamReader.Peek() >= 0)
            //{
            //    Console.WriteLine(streamReader.ReadLine());
            //}
            //streamReader.Close();

            LoadText("image1.txt");
            LoadText("images2.txt");
            LoadText("images3.txt");
            LoadText("images4.txt");

        }
    }
}
