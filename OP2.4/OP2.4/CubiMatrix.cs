namespace OP2._4;

public class CubiMatrix
{
    private int[,] Matrix { get; set;  }
    public int Size { get; set; }

    public CubiMatrix(int size)
    {
        Matrix = new int[size, size];
        Size = size;
    }

    public void FillMatrix()
    {
        Random random = new Random();
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                Matrix[i, j] = random.Next(-10, 10);
            }
        }
    }

    public int this[int raw, int col]
    {
        get { return Matrix[raw, col]; }
        set { Matrix[raw, col] = value; }
    }


    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                str += $"{Matrix[i, j]}\t";
            }

            str += "\n";
        }

        return str;
    }

    public static CubiMatrix operator +(CubiMatrix matr1, CubiMatrix matr2)
    {
        CubiMatrix resMatrix = new CubiMatrix(matr1.Size);
        for (int i = 0; i < matr1.Size; i++)
        {
            for (int j = 0; j < matr1.Size; j++)
            {
                resMatrix[i, j] = matr1[i, j] + matr2[i, j];
            }
        }

        return resMatrix;
    }

    public static CubiMatrix operator *(CubiMatrix matr1, CubiMatrix matr2)
    {
        CubiMatrix resMatrix = new CubiMatrix(matr1.Size);
        for (int i = 0; i < matr1.Size; i++)
        {
            for (int k = 0; k < matr1.Size; k++)
            {
                for (int j = 0; j < matr1.Size; j++)
                {
                    resMatrix[i, j] += matr1[i, k] * matr2[k, j];
                }
            }
        }

        return resMatrix;
    }
}