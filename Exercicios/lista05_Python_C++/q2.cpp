#include <iostream>
using namespace std;

int Maior(int n1, int n2, int n3){
    if (n1 >= n2 && n1 >= n3)
        cout << "O Valor " << n1 << " é o Maior!" << endl;
    else if (n2 >= n1 && n2 >= n3)
        cout << "O Valor " << n2 << " é o Maior!" << endl;
    else if (n3 >= n1 && n3 >= n2)
        cout << "O Valor " << n3 << " é o Maior!" << endl;
    
    return 0;
}

int main(){
    int number1, number2, number3;

    cout << "Digite o Primeiro Valor: ";
    cin >> number1;
    cout << "Digite o Segundo Valor: ";
    cin >> number2;
    cout << "Digite o Terceiro Valor: ";
    cin >> number3;

    Maior(number1, number2, number3);
    return 0; 
}