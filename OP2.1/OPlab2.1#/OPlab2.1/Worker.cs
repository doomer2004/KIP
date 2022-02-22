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
        public void CreateFile(string path)
        {
            StreamWriter streamWriter = new StreamWriter(path, append: false);
            streamWriter.Close();
        }
        public void AppendToFile(string path, string[] text)
        {
            StreamWriter streamWriter = new StreamWriter(path, append: true);
            foreach (var str in text)
            {
                streamWriter.WriteLine(str);
            }
            streamWriter.Close();
        }
        public void GetInput(string path)
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
        public void PrintFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        public string ReadFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string textFromFile = streamReader.ReadToEnd();
            streamReader.Close();

            return textFromFile;
        }
        public string[] CountFile(string path)
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