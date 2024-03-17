"""
Exercício 13

Tendo como dados de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule
seu peso ideal, usando as seguintes fórmulas:
    a. Para homens: (72.7*altura)-58
    b. Para mulheres: (62.1*h)-44.7
"""

altura = float(input("Digite a altura em metros: "))
peso_homem = round((72.7 * altura) - 58, 2)
peso_mulher = round((62.1 * altura) - 44.7, 2)
print(f"O peso ideal para a altura {altura}m é:")
print(f"\ta. Para homens: {peso_homem}kg")
print(f"\tb. Para mulheres: {peso_mulher}kg")
