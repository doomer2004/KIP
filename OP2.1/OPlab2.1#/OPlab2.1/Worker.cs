using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OPlab2._1
{
    class Worker
    {
        public void CreateFile(string path) //створення файлу
        {
            StreamWriter streamWriter = new StreamWriter(path, append: false);
            streamWriter.Close();
        }
        public void AppendToFile(string path, string[] text) //додає введений нами текст до файлу
        {
            StreamWriter streamWriter = new StreamWriter(path, append: true);
            foreach (var str in text)
            {
                streamWriter.WriteLine(str);
            }
            streamWriter.Close();
        }
        public void GetInput(string path) //вводимо текст до поки не нажата комбінація клавіш 
        {
            Console.WriteLine("Enter text(use shift + enter to close)");
            Console.CursorLeft = 0;
            CreateFile(path);
            var text = new List<string>();
            while (true)
            {
                string str = string.Empty;
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter && key.Modifiers == ConsoleModifiers.Shift)
                {
                    break;
                }
                else
                {

                    str = key.KeyChar + Console.ReadLine();
                    text.Add(str);
                }
            }
            AppendToFile(path, text.ToArray());
        }
        public void PrintFile(string path) //вивід вмісту файлу в консоль
        {
            Console.WriteLine(ReadFile(path));
        }
        public string ReadFile(string path) //прочитати вміст файлу
        {
            StreamReader streamReader = new StreamReader(path);
            string textFromFile = streamReader.ReadToEnd();
            streamReader.Close();

            return textFromFile;
        }
        public string[] CountFile(string path) //довжина кожної непарної строки
        {
            string[] text = ReadFile(path).Split('\n', (char)StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    text[i] = text[i].Replace("\r", "");
                    text[i] = text[i] + $" [{text[i].Length}]";
                }
                else
                {
                    text[i] = text[i].Replace("\r", "");
                }

            }
            return text;
        }
    }
}

