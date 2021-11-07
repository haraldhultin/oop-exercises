using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesReadWrite
{
    class NoteBook
    {
        private readonly string _pathNotesFile = "notes.txt";
        private readonly string _date = DateTime.Now.ToString();
        // 59
        public void TakeNote(string note)
        {
            if (!File.Exists(_pathNotesFile))
            {
                string dashedLine = new string('-', 39);
                string _header = $"{"Datum",-24} Note \n{dashedLine}\n";
                File.WriteAllText(_pathNotesFile, _header);
            }
            File.AppendAllText(_pathNotesFile, $"{_date,-24} {note} \n");
        }
        public string[] GetAllNotes() // Get all notes but ot not header.
        {
            if (!File.Exists(_pathNotesFile))
            {
                Console.WriteLine("file not found");
            }
            return File.ReadAllLines(_pathNotesFile)[2..];
        }
        public void AddNoteInputFromUser()
        {
            while (true)
            {
                Console.WriteLine("Enter text (enter EXIT to quit program) :");
                string input = Console.ReadLine();
                if (input == "EXIT") // leave loop if input is empty
                    break;
                TakeNote(input);
            }
        }


    }
}
