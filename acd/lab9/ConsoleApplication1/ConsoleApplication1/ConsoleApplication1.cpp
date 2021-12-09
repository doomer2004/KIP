#include <iostream>
#include<ctime>

using namespace std;
double** rand_matrix(int n) {
    double** mat = new double*[n];

    for (int i = 0; i < n; i++) {
        double* arr = new double[n];

        for (int j = 0; j < n; j++)
            arr[j] = rand() % 21 - 10;

        mat[i] = arr;
    }
    return mat;
}

double sum_diag(int n, double** matr) {
    double sum = 0;
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            sum += matr[i][j];
        }
    }
    return sum;
}
void print_matrix(int n, double** matr) {
    cout << "Matrix:\n";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cout << matr[i][j] << ' ';
        }
        cout << "\n";
    }
    cout << "\n";
}
int main()
{
    srand(time(NULL));
    int n;
    cin >> n;
    double** matr = rand_matrix(n);
    print_matrix(n, matr);
    cout << "Sum=" << sum_diag(n, matr);
}

