using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
namespace OPlab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            string path = @"C:\Users\HP\Downloads\text1.txt"; //файл в який ми записуємо весь введений текст
            string path2 = @"C:\Users\HP\Downloads\text2.txt"; //файл в який ми записуємо весь введений текст і вказуємо довжику парних строк
            worker.GetInput(path);
            worker.CreateFile(path2);
            worker.AppendToFile(path2, worker.CountFile(path));
            Console.WriteLine("\nFile 1");
            worker.PrintFile(path);
            Console.WriteLine("\nFile 2");
            worker.PrintFile(path2);
            Console.ReadLine();
        }
    }
}