/*
 * Exercício 12
 *
 * Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule
 * seu peso ideal, usando a seguinte fórmula: (72.7*altura)-58
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const altura = parseFloat(await rlp.question("Digite  a altura em metros: "))
rlp.close()
const peso = ((72.7 * altura) - 58).toFixed(2)

console.log(`O peso ideal para a altura de ${altura}m é ${peso}kg`)
