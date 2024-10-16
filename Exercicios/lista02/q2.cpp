#include <stdio.h>

int main(){
    char name[100];

    printf("Digite seu Nome Completo: ");
    scanf("%s", name);
    printf("Bem-Vindo ao Python, %s!", name);

    return 0;
}