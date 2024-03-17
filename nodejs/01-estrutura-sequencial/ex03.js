/*
 * Exercício 03
 *
 * Faça um Programa que peça dois números e imprima a soma.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})
const numeros = new Array(2)
for (let i = 0; i < numeros.length; i++) {
    const numero = await rlp.question("Digite um número: ")
    numeros[i] = parseInt(numero)
}
rlp.close()
console.log(`A soma dos números é: ${numeros.reduce((a, b) => a + b, 0)}`)
