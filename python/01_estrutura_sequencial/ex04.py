"""
Exercício 04

Faça um Programa que peça as 4 notas bimestrais e mostre a média.
"""

notas = []
for i in range(4):
    nota = int(input("Digite uma nota: "))
    notas.append(nota)
print(f"A média das notas é: {sum(notas) / len(notas)}")
