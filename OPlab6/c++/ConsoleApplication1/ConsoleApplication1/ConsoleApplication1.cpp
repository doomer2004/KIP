#include <iostream>


using namespace std;

int nsd(int a, int b); //прототип функції 

int main() {
    int num1, num2, num3, res;
    cout << "Enter 3 numbers" << endl;
    cin >> num1 >> num2 >> num3;
    res = nsd(nsd(num1, num2), num3);
    cout << "NSD = " << res << endl;
    return 0;
}

int nsd(int a, int b)  { //реалізація функції
    while (a != b) {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}