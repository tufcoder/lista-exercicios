"""
Exercício 07

Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área
para o usuário.
"""

lado = float(input("Digite o lado do quadrado: "))
area = pow(lado, 2) * 2
print(f"A área do quadrado dobrada é: {area:.2f}")
