"""
Exercício 17

Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros 
quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para
cada 6 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam 
R$ 80,00, ou galões de 3,6 litros, que custam R$ 25,00.
    Informe ao usuário a quantidade de tinta a serem compradas e os respectivos preços
    em 3 situações:
        * comprar apenas latas de 18 litros;
        * comprar apenas galões de 3,6 litros;
        * misturar latas e galões, de forma que o desperdício de tinta seja menor.
          Acrescente 10% de folga e sempre arredonde os valores para cima, isto é,
          considere latas cheias.
"""

from math import ceil, floor

COBERTURA = 1 * 6
LITROS_LATA = 18
LITROS_GALAO = 3.6
PRECO_LATA = 80.0
PRECO_GALAO = 25.0
FOLGA = 1.1

area = float(input("Área a ser pintada em m2: "))

litros = area / COBERTURA
latas = ceil(litros / LITROS_LATA)
galoes = ceil(litros / LITROS_GALAO)
preco_latas = latas * PRECO_LATA
preco_galoes = galoes * PRECO_GALAO

litros_folga = litros * FOLGA
latas_folga = floor(litros_folga / LITROS_LATA)
litros_folga = litros_folga - latas_folga * LITROS_LATA
galoes_folga = ceil(litros_folga / LITROS_GALAO)
preco_latas_folga = latas_folga * PRECO_LATA
preco_galoes_folga = galoes_folga * PRECO_GALAO

print("Apenas latas de 18 litros:")
print(f"\tVocê vai precisar de {latas} lata(s) de tinta no valor de R$ {preco_latas:.2f}")
print("Apenas galões de 3,6 litros:")
print(f"\tVocê vai precisar de {galoes} gal(ão/ões) de tinta no valor de R$ {preco_galoes:.2f}")
print(f"Misturar latas e galões. Acrescente 10% de folga {(litros * FOLGA):.2f}l:")
print(f"\tLatas: {latas_folga} lata(s) no valor de R$ {preco_latas_folga:.2f}")
print(f"\tGalões: {galoes_folga} gal(ão/ões) no valor de R$ {preco_galoes_folga:.2f}")
print(f"\tValor total: {(preco_latas_folga + preco_galoes_folga):.2f}")
