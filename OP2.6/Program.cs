using System;

namespace OPlab2._6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BiTree biTree = new BiTree('f');
            char[] chars = new[] { 'a', 'b', 'y', 'n', '7', '-', '+' };
            foreach (var gnida in chars)
            {
                biTree.Insert(gnida);
            }

            Console.WriteLine(biTree.PreorderTraverse());
            biTree.FindValue('-');
            Console.ReadLine();
        }
    }
}