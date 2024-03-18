"""
Exercício 18

Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade
de um link de internet (em Mbps), calcule e informe o tempo aproximado de download do
arquivo usando este link (em minutos).
"""

tamanho = float(input("Digite o tamanho do arquivo em MB: "))
velocidade = float(input("Velocidade da internet: "))

download = (tamanho * 8 / velocidade) / 60

print(f"O download irá demorar {download:.2f} minutos")
