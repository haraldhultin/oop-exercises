using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileExplorer
{
    class ConsoleExplorer
    {
        public void Run()
        {
            int index = 0;
            while (true)
            {
                string[] entries = Directory.GetFileSystemEntries(".");
                foreach (var element in entries)
                {
                    _ = element == entries[index] ? Console.ForegroundColor = ConsoleColor.Yellow : Console.ForegroundColor = ConsoleColor.Gray;
                    var prefix = File.Exists(element) ? "-" : "#"; // if file or dir
                    Console.WriteLine($"{prefix} {Path.GetFileName(element)}");
                }
                var key = Console.ReadKey(true).Key;
                index = key switch
                {
                    ConsoleKey.UpArrow => Math.Clamp( --index, 0, entries.Length-1),
                    ConsoleKey.DownArrow => Math.Clamp(++index, 0, entries.Length-1),
                    _ => 0
                };
                Console.Clear();
            }
        }
    }
}
