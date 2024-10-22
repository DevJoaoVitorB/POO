#include <iostream>
using namespace std;

int Maior(int n1, int n2){
    if (n1 >= n2)
        cout << "O Valor " << n1 << " é o Maior!" << endl;
    else
        cout << "O Valor " << n2 << " é o Maior!" << endl;
    
    return 0;
}

int main(){
    int number1, number2;

    cout << "Informe o Primeiro Valor: ";
    cin >> number1;
    cout << "Informe o Segundo Valor: ";
    cin >> number2;

    Maior(number1, number2);
    return 0;
}