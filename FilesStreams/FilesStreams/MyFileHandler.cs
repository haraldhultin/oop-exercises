using System;
using System.IO;
using System.Text;

namespace FilesStreams
{
    class MyFileHandler
    {
        public void ReadAllContent(string path)
        {
            //using (FileStream fs = File.OpenRead(path))
            //{
            //    byte[] b = new byte[1024];
            //    UTF8Encoding temp = new UTF8Encoding(true);
            //    UnicodeEncoding unicode = new UnicodeEncoding();
            //    while (fs.Read(b, 0, b.Length) > 0)
            //    {
            //        // Printing the file contents
            //        Console.WriteLine(temp.GetString(b));
            //    }
            //}
            using (FileStream fileStream = File.OpenRead(path))
            {
                StreamReader streamReader = new StreamReader(fileStream);
                //string line = "";
                //while (line != null)
                //while (streamReader.Peek() != -1)
                while (!streamReader.EndOfStream)
                {
                    //line = streamReader.ReadLine();
                    //Console.WriteLine(line);
                    Console.WriteLine(streamReader.ReadLine());
                }

            }
        }
            public void WriteContentToFile(string message, string path)
            {
                //FileStream fileStream = File.OpenWrite(path); // -- nödvändigt att gå via FileStream för att skapa StreamWriter?
                using (StreamWriter streamWriter = new StreamWriter(path, append: true))
                {                    
                    streamWriter.WriteLine(message);
                }
            }
        public void UpperCaseContent(string pathReadFrom, string pathWriteTo)
        {
            StreamReader streamReader = new StreamReader(pathReadFrom);
            while (!streamReader.EndOfStream)
            {
                using (StreamWriter streamWriter = new StreamWriter(pathWriteTo, append: true))
                {
                    streamWriter.WriteLine(streamReader.ReadLine().ToUpper());
                }
            }
            //FileStream fs = File.OpenRead(pathReadFrom); // CopyTo? hur? 
            //FileStream fsWrite = File.OpenWrite(pathWriteTo);
            //fs.CopyTo(fsWrite);
            //fs.Close();
            //fsWrite.Close();
        }
        public void ReadLatinEncodedContent()
        {
            using (FileStream fs = File.OpenRead("latin1.txt"))
            {
                int b;
                while ((b = fs.ReadByte()) != -1)
                {
                    Console.WriteLine(b);
                }                 
            }            
        }
    }
}
