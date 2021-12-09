#include <iostream>
using namespace std;
char* init_array(int n, char func (int)) {
    char* arr = new char[n];
    for (int i = 0; i < n; i++) {
        arr[i] = func(i);
    }
    return arr;
}char* iners(int n, char* arr1, char* arr2) {
    char* arr = new char[n] {};
    int l = 0;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            if (arr1[i] ==arr2[j])
            {
                arr[l] = arr1[i];
                l++;
            }
        }
    }
    return arr;
}
int count(int n, char* arr) {
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] !=0 && arr[i] < 115)
        {
            count++;
        }
    }
    return count;
}
char faf(int i) {
    return 120 - i;
}
char saf(int i) {
    return 110 + i;
}

int main()
{
    const int n = 10;
    char* arr1 = init_array(n, faf);
    char* arr2 = init_array(n, saf);
    char* arr3 = iners(n, arr1, arr2);
    cout << count(n, arr3);
}
