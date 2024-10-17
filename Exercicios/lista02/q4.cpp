#include <stdio.h>
#include <math.h>

float calc(int h, int b){
    float area, perimeter, diagonally;

    area = h * b;
    perimeter = h * 2 + b * 2;
    diagonally = sqrt(pow(h, 2) + pow(b, 2));

    return area, perimeter, diagonally;
}

int main(){
    int height, base;

    printf("Digite um Valor para a Altura e Base de um Retângulo: ");
    scanf("%d %d", height, base);

    printf("Area = %.2f - Perímetro = %.2f - Diagonal = %.2f", calc(height, base));
    return 0;
}
