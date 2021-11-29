
#include <iostream>
#include<cmath>
using namespace std;
int Foo(int x, int q, int b)
{
	if (b > 0)
		return (x) + Foo(x * q, q, b - 1);
	else
		return 0;
}
int main()
{
   cout << Foo(2, 2, 6);
}