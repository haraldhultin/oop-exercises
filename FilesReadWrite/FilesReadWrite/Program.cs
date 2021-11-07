using System;
using System.IO;
using System.Text;

namespace FilesReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFileHandler fileHandler = new();
            //Console.WriteLine(fileHandler.ReadAllContent("testfile1.txt"));
            //fileHandler.WriteContentToFile("hello town");
            //fileHandler.PrintAllContent("testfile2.txt");
            //fileHandler.UpperCaseContent("testfile1.txt", "testfile3.txt");
            //fileHandler.PrintAllContent("testfile3.txt");
            //fileHandler.ReadLatinEncodedContent("latin1.txt");

            NoteBook notebook = new();
            //notebook.TakeNote("first note");
            //notebook.TakeNote("second note");
            //notebook.TakeNote("buy milk");
            //fileHandler.PrintAllContent("notes.txt");
            //fileHandler.PrintAllContent(notebook.GetAllNotes());

            notebook.AddNoteInputFromUser();
            fileHandler.PrintAllContent("notes.txt");


        }
    }
}
