/*
 * Exercício 04
 *
 * Faça um Programa que peça as 4 notas bimestrais e mostre a média.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})
const notas = new Array(4)
for (let i = 0; i < notas.length; i++) {
    const nota = await rlp.question("Digite uma nota: ")
    notas[i] = parseFloat(nota)
}
rlp.close()
const media = notas.reduce((a, b) => a + b, 0) / notas.length
console.log(`A média das notas é: ${media}`)
