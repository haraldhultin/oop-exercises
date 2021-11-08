using System;

namespace FilesStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler fileHandler = new MyFileHandler();
            //fileHandler.ReadAllContent("testfile1.txt");
            //fileHandler.WriteContentToFile("town", "testfile2.txt");
            ////fileHandler.ReadAllContent("testfile2.txt");
            fileHandler.UpperCaseContent("testfile1.txt", "testfile3.txt");
            //fileHandler.ReadAllContent("testfile1.txt");
            fileHandler.ReadAllContent("testfile3.txt");
            //fileHandler.ReadLatinEncodedContent();
        }
    }
}
