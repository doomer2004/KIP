#include <iostream>
#include<ctime>
using namespace std;
int main()
{
    srand(time(NULL));
    int n, max, min, imin = 0;
    cout << "n=";
    cin >> n;
    int* B = new int[n];
   /* cin >> B[0];*/
    min = max = B[0] = rand() % 101;
    cout << B[0] << "\t";
    for (int i = 1; i < n; i++) {
        /*cin >> B[i];*/
        B[i] = rand() % 101;
        if (min > B[i]) {
            min = B[i];
            imin = i;
        }
        if (max < B[i]) {
            max = B[i];
            
        }
        
        cout << B[i] << "\t";
    }
    cout << '\n' << "MAX-MIN=" << max - min << '\n';
    int temp = B[imin];
    B[imin] = B[n - 1];
    B[n - 1] = temp;
    for (int i = 0; i < n; i++) {
        cout << B[i] << "\t";
    }
}