#include <iostream>
#include <ctime>

using namespace std;

int** input_matrix(int n);
int** rand_matrix(int n);
void print_matrix(int n, int** mat);
void print_array(int n, int* arr);
void sort(int n, int** arr);
int* main_diagonal(int n, int** matr);


int main()
{
    srand(time(NULL));

    int n;
    cin >> n;

    int** matr = rand_matrix(n);
    print_matrix(n, matr);

    sort(n, matr);
    print_matrix(n, matr);

    int* main_diag = main_diagonal(n, matr);
    print_array(n, main_diag);

}

int** input_matrix(int n) {
    int** mat = new int* [n];

    for (int i = 0; i < n; i++) {
        int* arr = new int[n];

        for (int j = 0; j < n; j++)
            cin >> arr[j];

        mat[i] = arr;
    }
    cout << '\n';
    return mat;
}

int** rand_matrix(int n) {
    int** mat = new int* [n];

    for (int i = 0; i < n; i++) {
        int* arr = new int[n];

        for (int j = 0; j < n; j++)
            arr[j] = rand() % 21 - 10;

        mat[i] = arr;
    }
    cout << '\n';
    return mat;
}

void print_matrix(int n, int** mat) {
    cout << "Matrix:\n";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cout << mat[i][j] << ' ';
        }
        cout << "\n";
    }
    cout << "\n";
}

void print_array(int n, int* arr) {
    cout << "Array:\n";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << ' ';
    }
    cout << '\n';
}

void sort(int n, int** arr) {
    for (int i = 1; i < n; i++) {
        int* cur = arr[i];
        int j = i - 1;
        while (j >= 0 and cur[0] > arr[j][0]) {
            arr[j + 1] = arr[j];
            j -= 1;
            arr[j + 1] = cur;
        }
    }
}

int* main_diagonal(int n, int** matr) {
    int* arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = matr[i][i];
    }
    return arr;
}