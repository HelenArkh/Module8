using System;
using System.Collections.Generic;
using System.Text;

namespace Module8
{
    public class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }

        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void CreateNewFolder(string folderName)
        {
            Folders.TryAdd(folderName, new Folder());

            Console.WriteLine($"Папка {folderName} создана");
        }
    }
}
