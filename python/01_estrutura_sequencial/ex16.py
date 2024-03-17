"""
Exercício 16

Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros 
quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para
cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam 
R$ 80,00. Informe ao usuário a quantidade de latas de tinta a serem compradas e o preço
total.
"""

from math import ceil


COBERTURA = 1 * 3
LITROS_LATA = 18
PRECO_LATA = 80.0

area = float(input("Área a ser pintada em m2: "))

litros = area / COBERTURA
latas = ceil(litros / LITROS_LATA)
preco_total = latas * PRECO_LATA

print(f"Você precisa comprar {latas} lata(s) de tinta")
print(f"O preço total é de R$ {preco_total:.2f}")
