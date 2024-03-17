/*
 * Exercício 08
 *
 * Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalha-
 * das no mês. Calcule e mostre o total do seu salário no referido mês.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const salarioHora = parseFloat(await rlp.question("Salário hora R$ "))
const horasTrabalhadas = parseFloat(await rlp.question("Horas trabalhadas: "))

rlp.close()

const salario = salarioHora * horasTrabalhadas
console.log(`Salário mensal R$ ${salario.toFixed(2)}`)
