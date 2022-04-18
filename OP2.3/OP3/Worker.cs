namespace OP3;

public class Worker
{
    public (int, int, double) FindRange()
    {
        Console.Write("Enter a(range): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b(range): ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter e(range): ");
        double e = double.Parse(Console.ReadLine());
        return (a, b, e);
    }

    public CubicPolynomial[] RandPoly(int size)
    {
        Random random = new Random();
        CubicPolynomial[] randPoly = new CubicPolynomial[size];
        for (int i = 0; i < size; i++)
        {
            randPoly[i] = new CubicPolynomial(random.Next(0, 10), random.Next(0, 10), random.Next(0, 10),
                random.Next(0, 10));
        }

        return randPoly;
    }

    public void PrintArray<T>(T[] array)
    {
        
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    public double[] FindAllRes(CubicPolynomial[] poly, int a, int b, double e)
    {
        double[] allRes = new double[poly.Length];
        
        for (int i = 0; i < poly.Length; i++)
        {
            allRes[i] = FindRes(poly[i], a, b, e);
        }

        return allRes;
    }

    private double FindRes(CubicPolynomial poly, int a, int b, double e)
    {
        double tempRes;
        double min = poly.Res(a);
        for (double i = a; i <= b; i += e)
        {
            tempRes = poly.Res(i);
            if (min > tempRes)
            {
                min = tempRes;
            }
        }

        return min;
    }

    public double MinRes(double[] allRes)
    {
        return allRes.Min();
    }

}