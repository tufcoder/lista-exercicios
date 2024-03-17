"""
Exercício 03

Faça um Programa que peça dois números e imprima a soma.
"""

numeros = []
for i in range(2):
    numero = int(input("Digite um número: "))
    numeros.append(numero)
print(f"A soma dos números é: {sum(numeros)}")
