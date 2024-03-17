/*
 * Exercício 09
 *
 * Faça um Programa que peça a temperatura em graus Fahrenheit, transforme e mostre a
 * temperatura em graus Celsius.
 * C = 5 * ((F-32)/9)
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const fahrenheit = parseFloat(await rlp.question("Fahrenheit: "))
rlp.close()

const celsius = parseFloat(5 * ((fahrenheit - 32) / 9)).toFixed(2)

console.log(`A temperatura convertida em Celsius é: ${celsius} graus`)
