"""
Exercício 06

Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
"""

import math

raio = float(input("Digite o raio do cículo: "))
area = round(math.pi, 2) * raio**2
area = round(math.pi, 2) * pow(raio, 2)
print(f"A área do cículo é: {area:.2f}cm2")
