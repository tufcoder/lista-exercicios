/*
 * Exercício 11
 *
 * Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
 *  a. o produto do dobro do primeiro com metade do segundo.
 *  b. a soma do triplo do primeiro com o terceiro.
 *  c. o terceiro elevado ao cubo.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const inteiros = []
for(let i = 0; i < 2; i++) {
    const inteiro = parseInt(await rlp.question("Digite um número inteiro: "))
    inteiros.push(inteiro)
}
const real = parseFloat(await rlp.question("Digite um número real: "))
rlp.close()
const a = parseFloat(inteiros[0]*2 + inteiros[1]/2).toFixed(2)
const b = parseFloat(inteiros[0]*3 + real).toFixed(2)
const c = parseFloat(Math.pow(real, 3)).toFixed(2)
console.log(`O produto do dobro do primeiro com metade do segundo: ${a}`)
console.log(`A soma do triplo do primeiro com o terceiro: ${b}`)
console.log(`O terceiro elevado ao cubo: ${c}`)
