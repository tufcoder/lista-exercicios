/*
 * Exercício 06
 *
 * Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const raio = parseFloat(await rlp.question("Digite o raio do círculo: "))
rlp.close()
// const area = Math.PI.toFixed(2) * raio**2
const area = Math.PI.toFixed(2) * Math.pow(raio, 2)
console.log(`A área do círculo é: ${area.toFixed(2)}cm2`)
