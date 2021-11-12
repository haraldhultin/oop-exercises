using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileExplorer
{
    class FolderView
    {
        public string path;
        private int _index = 0;
        public int Index { get { return _index; } set { _index = Math.Clamp(value, 0, entries.Length - 1); } }
        string[] entries;
        
        public string CurrentFileName 
        { 
            get { return Path.GetFileName(entries[Index]); } 
        }
        public FolderView()
        {
            path = Directory.GetCurrentDirectory();
        }
        public void PrintList(string path)
        {
            Console.Clear();
            entries = Directory.GetFileSystemEntries(path);
            foreach (var element in entries)
            {                
                Console.ForegroundColor = element == entries[Index] ? ConsoleColor.Yellow : ConsoleColor.Gray;
                var prefix = File.Exists(element) ? "-" : "#"; // if file or dir
                Console.WriteLine($"{prefix} {Path.GetFileName(element)}");
            }
        }
        public void Up()
        {
            Index--;
        }
        public void Down()
        {
            Index++;
        }
        public void EnterFolder()
        {
            Index = 0;
            PrintList(Path.GetFullPath(entries[Index]));
        }
    }
}
