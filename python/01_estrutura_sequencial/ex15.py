"""
Exercício 15

Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas
no mês. Calcule e mostre o total do seu salário no referido mês, sabendo-se que são
descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um
programa que nos dê:
    a. salário bruto.
    b. quanto pagou ao INSS.
    c. quanto pagou ao sindicato.
    d. o salário líquido.
    e. calcule os descontos e o salário líquido, conforme a tabela abaixo:
        + Salário Bruto: R$
        - IR (11%): R$
        - INSS (8%) : R$
        - Sindicato (5%): R$
        = Salário Líquido: R$
        Obs: Salário Bruto - Descontos = Salário Líquido.
"""

IR = 0.11
INSS = 0.08
SINDICATO = 0.05

valor_hora = float(input("Digite o seu valor hora R$: "))
horas_trabalhadas = float(input("Digite o total de horas trabalhadas: "))
salario_bruto = valor_hora * horas_trabalhadas
valor_ir = salario_bruto * IR
valor_inss = salario_bruto * INSS
valor_sindicato = salario_bruto * SINDICATO
descontos = valor_ir + valor_inss + valor_sindicato
salario_liquido = salario_bruto - descontos
print(f"\t+ Salário Bruto: R$ {salario_bruto:.2f}")
print(f"\t- IR (11%): R$ {valor_ir:.2f}")
print(f"\t- INSS (8%): R$ {valor_inss:.2f}")
print(f"\t- Sindicato (5%): R$ {valor_sindicato:.2f}")
print(f"\t= Salário Líquido: R$ {salario_liquido:.2f}")
print(f"O total de descontos é de R$ {descontos:.2f}")
