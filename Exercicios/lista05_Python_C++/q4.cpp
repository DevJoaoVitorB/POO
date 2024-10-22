#include <iostream>
using namespace std;

int Aprovado(int note1, int note2){
    int media = (note1 * 2 + note2 * 3) / 5;

    if (media >= 60)
        cout << "O Aluno está Aprovado? True" << endl;
    else
        cout << "O Aluno está Aprovado? False" << endl;
    
    return 0;
}

int main(){
    int note1, note2;

    cout << "Informe a Primeira Nota: ";
    cin >> note1;
    cout << "Informe a Segunda Nota: ";
    cin >> note2;

    Aprovado(note1, note2);
    return 0;
}