using System;
using System.Linq;

namespace OP2._5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Worker worker = new Worker();
            var workers = worker.getValues();
            worker.Print(workers);
            Console.WriteLine("---------------------------------------");
            var pay =worker.GetTax(workers);
            worker.PrintPayment(pay);
            Console.ReadLine();
        }
    }
}