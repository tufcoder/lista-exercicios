"""
Exercício 10

Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus
Fahrenheit.
"""

celsius = float(input("Celsius: "))
fahrenheit = round(celsius * 9 / 5 + 32, 2)
print(f"A temperatura convertida em Fahrenheit é: {fahrenheit} graus")
