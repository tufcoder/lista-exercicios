/*
 * Exercício 10
 *
 * Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus
 * Fahrenheit.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const celsius = parseFloat(await rlp.question("Celsius: "))
rlp.close()

const fahrenheit = parseFloat(celsius * 9 / 5 + 32).toFixed(2)

console.log(`A temperatura convertida em Fahrenheit é: ${fahrenheit} graus`)
