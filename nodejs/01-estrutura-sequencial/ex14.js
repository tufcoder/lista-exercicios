/*
 * Exercício 14
 *
 * João Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar o
 * rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que 
 * o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar
 * uma multa de R$ 4,00 por quilo excedente. João precisa que você faça um programa que
 * leia a variável *peso* (peso de peixes) e calcule o excesso. Gravar na variável
 * *excesso* a quantidade de quilos além do limite e na variável *multa* o valor da multa
 * que João deverá pagar. Imprima os dados do programa com as mensagens adequadas.
 */

import * as readlinePromises from 'node:readline/promises'
import { stdin as input, stdout as output } from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const PESO_LIMITE = 50.0
const VALOR_MULTA = 4.0

const peso = parseFloat(await rlp.question("Peso de peixes em kg: ")).toFixed(2)
rlp.close()
const excesso = (peso - PESO_LIMITE).toFixed(2)
const multa = parseFloat(excesso * VALOR_MULTA).toFixed(2)

console.log(`Você informou que pescou ${peso}kg de peixes`)
if (excesso > 0) {
    console.log(`Peso excedido: ${excesso}kg`)
    console.log(`Você passou do limite, deverá pagar uma multa de R$ ${multa}`)
} else {
    console.log("O peso limite não foi excedido, você não tem multa para pagar :)")
}
