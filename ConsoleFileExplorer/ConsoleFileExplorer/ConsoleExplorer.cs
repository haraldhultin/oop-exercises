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
        private ViewState _viewState = ViewState.List;
        public void Run()
        {
            FolderView folderView = new FolderView();
            while (true)
            {
                if (_viewState == ViewState.List) { folderView.PrintList(folderView.path); }
                if (_viewState == ViewState.FileView)
                {
                    Console.Clear();
                    string currentFileData = File.ReadAllText(folderView.CurrentFileName);
                    Console.WriteLine(currentFileData);
                    Console.Write("Tryck på mellanslag för att gå tillbaka till listan");
                    Console.ReadKey(true);
                    _viewState = ViewState.List;
                    continue;
                }


                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow: folderView.Up(); break;
                    case ConsoleKey.DownArrow: folderView.Down(); break;
                    case ConsoleKey.Spacebar: 
                        _viewState = _viewState == ViewState.FileView ? ViewState.List : ViewState.FileView; break;
                    case ConsoleKey.Enter: folderView.EnterFolder(); break;
                    default: break;
                }
            }           
        }
    }
}
