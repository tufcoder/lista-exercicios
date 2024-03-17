/*
 * Exercício 13
 *
 * Tendo como dados de entrada a altura (h) de uma pessoa, construa um algoritmo que
 * calcule seu peso ideal, usando as seguintes fórmulas:
 *      a. Para homens: (72.7*h)-58
 *      b. Para mulhers: (62.1*h)-44.7
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const altura = parseFloat(await rlp.question("Digite  a altura em metros: "))
rlp.close()
const pesoHomem = ((72.7 * altura) - 58).toFixed(2)
const pesoMulher = ((62.1 * altura) - 44.7).toFixed(2)

console.log(`O peso ideal para a altura ${altura}m é:`)
console.log(`\ta. Para homens: ${pesoHomem}kg`)
console.log(`\tb. Para mulheres: ${pesoMulher}kg`)
