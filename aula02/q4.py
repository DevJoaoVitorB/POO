import math

print("Digite Base e Altura do Retângulo: ")
base = int(input())
altura = int(input())

area = base * altura
perimetro = 2 * base + 2 * altura
diagonal = math.sqrt(base ** 2 + altura ** 2)

print(f"Área = {area:.2f} - Perímetro = {perimetro:.2f} - Diagonal = {diagonal:.2f}")