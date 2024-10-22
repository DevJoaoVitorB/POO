name = input("Digite seu Nome: ").split()
formatation = []

def format(name):
    for i in range(0, len(name)):
        formatation.append(name[i].capitalize())
    return formatation

print("Seu Nome Formatado:", *format(name))