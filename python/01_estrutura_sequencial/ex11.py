"""
Exercício 11

Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
    a. o produto do dobro do primeiro com metade do segundo.
    b. a soma do triplo do primeiro com o terceiro.
    c. o terceiro elevado ao cubo.
"""

inteiros = []
for i in range(2):
    inteiro = int(input("Digite um número inteiro: "))
    inteiros.append(inteiro)
real = float(input("Digite um número real: "))
a = round(inteiros[0]*2 + inteiros[1]/2, 2)
b = round(inteiros[0]*3 + real, 2)
c = round(real**3, 2)
print(f"O produto do dobro do primeiro com metade do segundo: {a}")
print(f"A soma do triplo do primeiro com o terceiro: {b}")
print(f"O terceiro elevado ao cubo: {c}")
