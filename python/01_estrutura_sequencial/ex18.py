"""
Exercício 18

Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade
de um link de internet (em Mbps), calcule e informe o tempo aproximado de download do
arquivo usando este link (em minutos).
"""

from math import floor

tamanho = float(input("Digite o tamanho do arquivo em MB: "))
velocidade = float(input("Velocidade da internet em Mbps: "))

minutos = (tamanho * 8 / velocidade) / 60
segundos = (minutos - floor(minutos)) * 60

if segundos > 0:
    print(f"O download irá demorar {floor(minutos)} minuto(s) e {round(segundos)} segundo(s)")
else:
    print(f"O download irá demorar {round(minutos)} minuto(s)")
