name = input("Digite seu Nome Completo: ")
inicial = []

def fragmetation(name):
    frag = name.split()
    for i in range(0, len(frag)):
        if len(frag[i]) > 2:
            value = list(frag[i])
            inicial.append(value[0])
    return inicial

print("As Iniciais do Seu Nome São:", *fragmetation(name))
