n1, n2 = map(int, input("Informe as Duas Notas: ").split())

def aprovado(n1, n2):
    media = (n1 * 2 + n2 * 3) // 5
    if media >= 60:
        return True
    else:
        return False

print(f"O Aluno está Aprovado? {aprovado(n1, n2)}")