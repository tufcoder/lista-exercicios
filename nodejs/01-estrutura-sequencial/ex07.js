/*
 * Exercício 07
 *
 * Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta
 * área para o usuário.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const lado = parseFloat(await rlp.question("Digite o lado do quadrado: "))
rlp.close()
const area = Math.pow(lado, 2) * 2
console.log(`A área do quadrado é: ${area.toFixed(2)}`)
