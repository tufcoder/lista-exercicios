"""
Exercício 08

Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas
no mês. Calcule e mostre o total do seu salário no referido mês.
"""

salario_hora = float(input("Salário hora R$ "))
horas_trabalhadas = float(input("Horas trabalhadas: "))
salario = round(salario_hora * horas_trabalhadas, 2)
print(f"Salário mensal R$ {salario:.2f}")
