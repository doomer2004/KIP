#include <iostream>
#include<cmath>
using namespace std;

int main()
{
    int x, n;
    int f = 1; // початкове значення дільника
    double s = 0; // початкове значення суми
    double form; // задання змінної для геометричної прогресії
    cout << "Enter x=";
    cin >> x; // користувач вводить значення x
    cout << "Enter for how many first n members we calculate the value=";
    cin >> n; // користувач вводить кількість перших n
    if (n > 0){ // умова перевірки невідє'ємнності n
        for (int n1 = 1; n1 <= n; n1++) //задання циклу 
        {
            form = pow(x, n1 - 1) / f; //формула для геометричної прогресії 
            f = f * (n1); // перезапис дільника
            s = s + form; // перезапис суми
            cout << "Sum for n=" << n1 << '\n' << "S=" << s << '\n'; // виведення кожної нової суми

        }
    cout << "The final S=" << s; // фінальне значення суми
}
    else{
        cout << "value is incorrect"; //значення не коректні
    }
    return 0;
}

