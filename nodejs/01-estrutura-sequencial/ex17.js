/*
 * Exercício 17
 *
 * Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros 
 * quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para
 * cada 6 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam
 * R$ 80,00 ou em galões de 3,6 litros, que custam R$ 25,00.
 * 
 * Informe ao usuário as quantidades de tinta a serem compradas e os respectivos preços
 * em 3 situações:
 *      - comprar apenas latas de 18 litros;
 *      - comprar apenas galões de 3,6 litros;
 *      - misturar latas e galões, de forma que o desperdício de tinta seja menor.
 *        Acrescente 10% de folga e sempre arredonde os valores para cima, isto é,
 *        considere latas cheias.
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const COBERTURA = 1 * 6
const LITROS_LATA = 18
const LITROS_GALAO = 3.6
const PRECO_LATA = 80.0
const PRECO_GALAO = 25.0
const FOLGA = 1.1

const area = parseFloat(await rlp.question("Área a ser pintada em m2: "))

const litros = area / COBERTURA
const latas = Math.ceil(litros / LITROS_LATA)
const galoes = Math.ceil(litros / LITROS_GALAO)
const precoLatas = latas * PRECO_LATA
const precoGaloes = galoes * PRECO_GALAO

let litrosFolga = litros * FOLGA
const latasFolga = Math.floor(litrosFolga / LITROS_LATA)

litrosFolga = litrosFolga - latasFolga * LITROS_LATA

const galoesFolga = Math.ceil(litrosFolga / LITROS_GALAO)
const precoLatasFolga = latasFolga * PRECO_LATA
const precoGaloesFolga = galoesFolga * PRECO_GALAO

console.log("Apenas latas de 18 litros")
console.log(`\tVocê vai precisar de ${latas} lata(s) de tinta no valor de R$ ${precoLatas.toFixed(2)}`)
console.log("Apenas galões de 3,6 litros")
console.log(`\tVocê vai precisar de ${galoes} gal(ão/ões) de tinta no valor de R$ ${precoGaloes.toFixed(2)}`)
console.log(`Misturar latas e galões: Acrescente 10% de folga ${(litros * FOLGA).toFixed(2)}l`)
console.log(`\tLatas: ${latasFolga} lata(s) no valor R$ ${precoLatasFolga.toFixed(2)}`)
console.log(`\tGalões: ${galoesFolga} gal(ão/ões) no valor R$ ${precoGaloesFolga.toFixed(2)}`)
console.log(`\tValor Total: ${(precoLatasFolga + precoGaloesFolga).toFixed(2)}`)
