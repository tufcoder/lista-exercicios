"""
Exercício 12

Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu
peso ideal, usando a seguinte fórmula: (72.7*altura)-58
"""

altura = float(input("Digite a altura em metros: "))
peso = round((72.7 * altura) - 58, 2)
print(f"O peso ideal para a altura de {altura}m é {peso}kg")
