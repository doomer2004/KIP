#include <iostream>
#include <string>
using namespace std;

string* split(string, char); //функція що розділяє строку на слова
int getWordsCount(string, char); //обчислення кількості слів в строці

int main() {
    string input;
    getline(cin, input);
    int len;
    cin >> len;
    string* words = split(input, ' '); //масив слів введених в строці
    int wordsCount = getWordsCount(input, ' '); //кількість слів
    string* result = new string[wordsCount]; //результат 
    int count = 0; 
    for (int i = 0; i < wordsCount; i++) 
    {
        if (words[i].length() == len) {
            result[count++] = words[i];
        }
    }
    for (int i = 0; i < wordsCount; i++)
    {
        cout << result[i] << endl;
    }
}
string* split(string input, char separ)
{
    string input_editable = input;
    string* words = new string[getWordsCount(input_editable, separ)];
    string currWord = "";
    int i = 0;
    for (int inputIndex = 0; inputIndex < input_editable.length(); inputIndex++)
    {
        bool isLastChar = inputIndex == input_editable.length() - 1; //перевірка на кінець строки
        bool isSepar = input[inputIndex] == separ; //перевірка на розділяючий символ
        if (!isSepar) 
        {
            currWord += input_editable[inputIndex];
        }
        if (isSepar || isLastChar)
        {
            if (currWord != "")
                words[i++] = currWord;
            currWord = "";
        }
    }
    return words;
}

int getWordsCount(string input, char separ) {
    int count = 1;
    int lastChar = 0;
    for (int i = 0; i < input.length(); i++)
    {
        if (input[i] != separ) {
            if (i - lastChar > 1)
                count++;
            lastChar = i;
        }
    }
    return count;
}