#include <stdio.h>

int main(){
    int n1;
    int n2;

    printf("Digite sua Primeira Nota: ");
    scanf("%d", &n1);

    printf("Digite sua Segunda Nota: ");
    scanf("%d", &n2);

    int note = ((n1 * 2) + (n2 * 3))/5;

    printf("Media Parcial: %d", note);

    return 0;
}