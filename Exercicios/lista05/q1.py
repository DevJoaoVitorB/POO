n1, n2 = map(int, input("Digite Dois Valores: ").split())

def Maior(n1, n2):
    if n1 > n2:
        return n1
    else:
        return n2

print(f"O Valor {Maior(n1, n2)} é o Maior!")