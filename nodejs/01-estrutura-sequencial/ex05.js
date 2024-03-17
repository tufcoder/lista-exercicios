/*
 * Exercício 05
 *
 * Faça um Programa que converta metros para centímetros.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const metros = parseFloat(await rlp.question("Metros: "))
rlp.close()
const centimetros = metros * 100
console.log(`${metros.toFixed(2)}m convertido em centímetros fica ${centimetros.toFixed(2)}cm`)
