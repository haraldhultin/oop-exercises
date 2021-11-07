using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadWrite
{
    class MyFileHandler
    {
        public void PrintAllContent(string path)
        {
            Console.WriteLine(File.ReadAllText(path) + " --" + path);
        }
        public void PrintAllContent(string[] stringArray)
        {
            foreach (var element in stringArray)
            {
                Console.WriteLine(element);
            }
        }
        public string ReadAllContent(string path)
        {
            return File.ReadAllText(path);
        }
        public void WriteContentToFile(string text)
        {
            File.WriteAllText("testfile2.txt", text);
        }

        public void UpperCaseContent(string pathFileToReadFrom, string pathFileToWriteTo) 
        {               
            File.WriteAllText(pathFileToWriteTo, File.ReadAllText(pathFileToReadFrom).ToUpper());
        }
        public void ReadLatinEncodedContent(string pathFileToReadFrom)
        {
            Console.WriteLine(   File.ReadAllText(pathFileToReadFrom, Encoding.Latin1));
        }
        
    }

}