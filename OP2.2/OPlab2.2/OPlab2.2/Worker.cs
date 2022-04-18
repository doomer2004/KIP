using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
namespace OPlab2._2
{
    class Worker
    {
        public void CreateFile(string path)
        {
            FileStream fstream = new FileStream(path, FileMode.Create);

            fstream.Close();
        }
        public void AppendToFile(string path, string calls)
        {
            FileStream fstream = new FileStream(path, FileMode.Append);
            byte[] buffer = new byte[calls.Length];
            fstream.Write(buffer, 0, calls.Length);
            fstream.Close();
        }
        public string TakeColls(string path)
        {
            Console.WriteLine("Enter all calls:");
            int num = int.Parse(Console.ReadLine());
            var phoneBook = new Dictionary<string, TimeOnly>();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter phone number:");
                string pnum = Console.ReadLine();
                Console.WriteLine("Enter time:");
                TimeOnly time = TimeOnly.Parse(Console.ReadLine());

            }

            return;
        }
            
    }
}
