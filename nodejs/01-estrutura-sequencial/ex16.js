/*
 * Exercício 16
 *
 * Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros
 * quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para
 * cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam 
 * R$ 80,00. Informe ao usuário a quantidade de latas de tinta a serem compradas e o 
 * preço total.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const COBERTURA = 1 * 3
const LITROS_LATA = 18
const PRECO_LATA = 80.0

const area = parseFloat(await rlp.question("Área a ser pintada em m2: "))
rlp.close()
const litros = area / COBERTURA
const latas = Math.ceil(litros / LITROS_LATA)
const precoTotal = latas * PRECO_LATA

console.log(`Você precisa comprar ${latas} lata(s) de tinta`)
console.log(`O preço total é de R$ ${precoTotal.toFixed(2)}`)
