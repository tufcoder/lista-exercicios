/*
 * Exercício 02
 *
 * Faça um Programa que peça um número e então mostre a mensagem
 * "O número informado foi [número].
 */

import * as readline from 'node:readline'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readline.createInterface({input, output})

rlp.question("Digite um número: ", (numero) => {
    console.log(`O número informado foi [${parseInt(numero)}]`)
    rlp.close()
})
