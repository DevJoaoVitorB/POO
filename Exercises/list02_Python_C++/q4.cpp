#include <iostream>
#include <math.h>
using namespace std;

int main(){
    int height, base;
    float area, perimeter, diagonally;

    cout << "Digite um Valor para a Altura e Base de um Retângulo: ";
    cin >> height >> base;

    area = height * base;
    perimeter = height * 2 + base * 2;
    diagonally = sqrt(pow(height, 2) + pow(base, 2));

    cout << "Area = " << area << " - Perímetro = " << perimeter << " - Diagonal = " << diagonally << endl;
    return 0;
}