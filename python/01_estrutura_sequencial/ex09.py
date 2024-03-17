"""
Exercício 09

Faça um Programa que peça a temperatura em graus Fahrenheit, transforme e mostre a tempe-
ratura em graus Celsius.
C = 5 * ((F-32)/9)
"""

fahrenheit = float(input("Fahrenheit: "))
celsius = round(5 * ((fahrenheit - 32) / 9), 2)
print(f"A temperatura convertida em Celsius é: {celsius} graus")
