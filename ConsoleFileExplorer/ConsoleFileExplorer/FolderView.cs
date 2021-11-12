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
        private int _index = 0;
        string[] entries;
        public void PrintList()
        {
            Console.Clear();
            entries = Directory.GetFileSystemEntries(".");
            foreach (var element in entries)
            {
                Console.ForegroundColor = element == entries[_index] ? ConsoleColor.Yellow : ConsoleColor.Gray;
                var prefix = File.Exists(element) ? "-" : "#"; // if file or dir
                Console.WriteLine($"{prefix} {Path.GetFileName(element)}");
            }
        }
        public void Up()
        {
            _index = Math.Clamp(--_index, 0, entries.Length - 1);
        }
        public void Down()
        {
            _index = Math.Clamp(++_index, 0, entries.Length - 1);
        }
    }
}
