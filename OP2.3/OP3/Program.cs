using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            (int a, int b, double e) = worker.FindRange();
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            var cubicPolynomials = worker.RandPoly(size);
            Console.WriteLine();
            worker.PrintArray(cubicPolynomials);
            var findAllRes = worker.FindAllRes(cubicPolynomials, a, b, e);
            Console.WriteLine("\nAll:");
            worker.PrintArray(findAllRes);
            Console.WriteLine("\nMin:");
            Console.WriteLine(worker.MinRes(findAllRes));
            Console.ReadLine();
        }
    }
}