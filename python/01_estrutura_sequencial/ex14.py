"""
Exercício 14

João Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar o
rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que o
estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma
multa de R$ 4,00 por quilo excedente. João precisa que você faça um programa que leia a
variável *peso* (peso de peixes) e calcule o excesso. Gravar na variável *multa* o valor
da multa que João deverá pagar. Imprima os dados do programa com as mensagens adequadas.
"""

PESO_LIMITE = 50.0
VALOR_MULTA = 4.0

peso = float(input("Peso de peixes em kg: "))
excesso = peso - PESO_LIMITE
multa = excesso * VALOR_MULTA

print(f"Você informou que pescou {peso:.2f}kg de peixes")
if excesso > 0:
    print(f"Peso excedido: {excesso:.2f}kg")
    print(f"Você passou do limite, deverá pagar uma multa de R$ {multa:.2f}")
else:
    print("O peso limite não foi excedido, você não tem multa para pagar ☺️  ")
