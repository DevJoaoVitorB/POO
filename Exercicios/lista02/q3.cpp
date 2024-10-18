#include <iostream>
using namespace std;

int main(){
    int n1;
    int n2;

    cout << "Digite sua Primeira Nota: ";
    cin >> n1;
    cout << "Digite sua Segunda Nota: ";
    cin >> n2;

    int note = ((n1 * 2) + (n2 * 3))/5;

    cout << "Media Parcial: " << note << endl;

    return 0;
}