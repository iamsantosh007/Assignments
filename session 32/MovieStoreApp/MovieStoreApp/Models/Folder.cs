using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieStoreApp.Models
{
    public class Folder : IStorageItem
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private int _space;

        private List<IStorageItem> _items;
        public List<IStorageItem> Items { get { return _items; } set { _items = value; } }

        public int Space { get { return _space; } set { _space = value; } }

        public Folder()
        {
            _items = new List<IStorageItem>();

        }

        public void AddChild(IStorageItem item)
        {
            item.Space = this._space + 1;
            _items.Add(item);

        }
        public void Display()                                           //Display all movies
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < _space; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine($"{_space}) The folderName is {Name}");
            Console.ResetColor();
            GroupOfFolder(this, Items);
        }
        private static void GroupOfFolder(Folder folder, List<IStorageItem> items)  //Display all movies inside folder
        {

            foreach (IStorageItem item in items)
            {

                if (item.GetType().Name.ToString() == "Folder")
                {
                    //item.Space = folder.Space + 1;
                    item.Display();
                    continue;
                }
                if (item.GetType().Name.ToString() == "FileSystem")
                {
                    // item.Space = folder.Space + 1;
                    item.Display();
                }
            }
        }



        public void DisplayFolderByIndexOrLevel(int indexOutside)   //Display folder By indexLevel
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"The folder on index {indexOutside} is follows:-\n\n");
            Console.ResetColor();

            foreach (IStorageItem item in _items)
            {
                if (item.GetType().Name == "Folder")
                {
                    if (item.Space == indexOutside + 1)
                    {
                        DisplayOnlyFolderInfo((Folder)item);
                        continue;
                    }
                    GroupOfFolderInfo((Folder)item, ((Folder)item).Items);


                }
            }
        }

        private void DisplayOnlyFolderInfo(Folder folder)              //Used to display Only the folders inside the folder
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < folder.Space; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine($"{folder.Space}) The folderName is {folder.Name}");
            Console.ResetColor();
            GroupOfFolderInfo(folder, folder.Items);
        }

        private void GroupOfFolderInfo(Folder folder, List<IStorageItem> items)  //Used to display Only the folders inside the folder
        {
            foreach (IStorageItem item in items)
            {

                if (item.GetType().Name.ToString() == "Folder")
                {
                    //item.Space = folder.Space + 1;
                    DisplayOnlyFolderInfo(((Folder)item));
                    continue;
                }
            }
        }











        public void DisplayFileByIndexOrLevel(int indexOutside)   //Display file By indexLevel
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"The file on index {indexOutside} is follows:-\n\n");
            Console.ResetColor();
            foreach (IStorageItem item in _items)
            {
                if (item.GetType().Name == "FileSystem")
                {
                    if (item.Space == indexOutside + 1)
                    {
                        DisplayOnlyFileInfo((FileSystem)item);
                        continue;
                    }
                    continue;

                }
                GroupOfFileInfo(((Folder)item), ((Folder)item).Items, indexOutside);
            }
        }

        private void DisplayOnlyFileInfo(FileSystem file)              //Used to display Only the file inside the folder
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < file.Space; i++)
            {
                Console.Write("---");
            }
            Console.WriteLine($"{file.Space}) The folderName is {file.Name} and size is {file.Size}");
            Console.ResetColor();
            //GroupOfFolderInfo(folder, folder.Items);
        }

        private void GroupOfFileInfo(Folder folder, List<IStorageItem> items, int index)  //Used to display Only the file inside the folder
        {

            foreach (IStorageItem item in items)
            {
                if (index == item.Space)
                {
                    if (item.GetType().Name.ToString() == "FileSystem")
                    {
                        //item.Space = folder.Space + 1;
                        DisplayOnlyFileInfo(((FileSystem)item));
                        continue;
                    }
                }
                if (item.GetType().Name.ToString() == "Folder")
                {
                    GroupOfFileInfo(((Folder)item), ((Folder)item).Items, index);
                }
            }



        }



    }
}
