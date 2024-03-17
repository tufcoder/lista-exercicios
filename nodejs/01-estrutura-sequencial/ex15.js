/*
 * Exercício 15
 *
 * Faça um Programa que pergunte quanto você ganha por hora e o número de horas
 * trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês,
 * sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para
 * o Sindicato, faça um programa que nos dê:
 *      a. salário bruto.
 *      b. quanto pagou ao INSS.
 *      c. quanto pagou ao Sindicato.
 *      d. salário líquido.
 *      e. calcule os descontos e o salário líquido, conforme a tabela abaixo:
 *          + Salário Bruto: R$
 *          - IR (11%): R$
 *          - INSS (8%): R$
 *          - Sindicato (5%): R$
 *          = Salário Líquido: R$
 *          Obs: Salário Bruto - Descontos = Salário Líquido.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const IR = 0.11
const INSS = 0.08
const SINDICATO = 0.05

const valorHora = parseFloat(await rlp.question("Digite o seu valor hora R$: "))
const horasTrabalhadas = parseFloat(await rlp.question("Digite o total de horas trabalhadas: "))
rlp.close()

const salarioBruto = valorHora * horasTrabalhadas
const valorIR = salarioBruto * IR
const valorINSS = salarioBruto * INSS
const valorSindicato = salarioBruto * SINDICATO
const descontos = valorIR + valorINSS + valorSindicato
const salarioLiquido = salarioBruto - descontos

console.log(`\t+ Salário Bruto: R$ ${salarioBruto.toFixed(2)}`)
console.log(`\t- IR (11%): R$ ${valorIR.toFixed(2)}`)
console.log(`\t- INSS (8%): R$ ${valorINSS.toFixed(2)}`)
console.log(`\t- Sindicato (5%): R$ ${valorSindicato.toFixed(2)}`)
console.log(`\t= Salário Líquido: R$ ${salarioLiquido.toFixed(2)}`)
console.log(`O total de descontos é de R$ ${descontos.toFixed(2)}`)
