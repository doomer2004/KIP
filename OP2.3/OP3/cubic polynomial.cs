using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
namespace OP3;

public class CubicPolynomial
{
    private int A3{ get; init; }
    private int A2{ get; init; }
    private int A1{ get; init; }
    private int A0{ get; init; }
    
    public CubicPolynomial(int a3, int a2, int a1, int a0)
    {
        A3 = a3;
        A2 = a2;
        A1 = a1;
        A0 = a0;
    }
    
    public override string ToString()
    {
        return $"{A3}x^3 + {A2}x^2 +{A1}x + {A0}";
    }

    public double Res(double x)
    {
        return A3 * Math.Pow(x, 3) + A2 * Math.Pow(x, 2) + A1 * x + A0;
    }
    
}