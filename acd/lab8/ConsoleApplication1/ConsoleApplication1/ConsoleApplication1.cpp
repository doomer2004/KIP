
#include<ctime>
#include <iostream>
using namespace std;
int** rand_matrix(int n, int m) {
    int** mat = new int* [n];
    srand(time(NULL));

    for (int i = 0; i < n; i++) {
        int* arr = new int[m];

        for (int j = 0; j < m; j++)
            arr[j] = rand() % 21 - 10;

        mat[i] = arr;
    }
    return mat;
}

void print_matrix(int n, int m, int** mat) {
    cout << "Matrix:\n";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cout << mat[i][j] << ' ';
        }
        cout << "\n";
    }
    cout << "\n";
}

void print_array(int length, int* arr) {
    cout << "Array:\n";
    for (int i = 0; i < length; i++) {
        cout << arr[i] << ' ';
    }
    cout << '\n';
}

int* sum_col(int n, int m, int** matr) {
    int* arr = new int[m];

    for (int i = 0; i < m; i++) {
        int sum = 0;
        for (int j = 0; j < n; j++)
            sum += matr[j][i];
        arr[i] = sum;
    }
    return arr;
}
void sort(int length, int* arr) {
    bool swaped = 1;
    for (int i = 0; i < length && swaped; i++) 
    {
        swaped = 0;
        for (int j = 1; j < length; j++) {
            if (arr[j - 1] > arr[j]) {
                swap(arr[j - 1], arr[j]);
                swaped = 1;
            }
                
        }
    }
}
int main()
{
    const int n = 5, m = 7;
    int** matr = rand_matrix(n, m);
    print_matrix(n, m, matr);
    int* arr = sum_col(n, m, matr);
    print_array(m, arr);
    sort(m, arr);
    print_array(m, arr);
}

