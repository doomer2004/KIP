namespace OP2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter matrix size: ");
            int size = int.Parse(Console.ReadLine());
            CubiMatrix M1 = new CubiMatrix(size);
            M1.FillMatrix();
            CubiMatrix M2 = new CubiMatrix(size);
            M2.FillMatrix();
            CubiMatrix M3 = new CubiMatrix(size);
            Console.WriteLine("M1 matrix:");
            Console.WriteLine(M1.ToString());
            Console.WriteLine("M2 matrix:");
            Console.WriteLine(M2.ToString());
            M3 = M1 + M2;
            Console.WriteLine("M1+M2 matrix:");
            Console.WriteLine(M3.ToString());
            M3 = M3 * M3;
            Console.WriteLine("M3*M3 matrix:");
            Console.WriteLine(M3.ToString());
            Console.ReadLine();
        }
    }
}