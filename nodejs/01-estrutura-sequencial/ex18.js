/*
 * Exercício 18
 *
 * Faça um Programa que peça o tamanho de um arquivo para download (em MB) e a velocidade
 * de um link de internet (em Mbps), calcule e informe o tempo aproximado de download do
 * arquivo usando este link (em minutos).
 */

import * as readlinePromises from 'node:readline/promises'
import {stdin as input, stdout as output} from 'node:process'

const rlp = readlinePromises.createInterface({input, output})

const tamanho = parseFloat(await rlp.question("Digite o tamanho do arquivo em MB: "))
const velocidade = parseFloat(await rlp.question("Velocidade da internet em Mbps: "))
rlp.close()

const minutos = (tamanho * 8 / velocidade) / 60
const segundos = (minutos - Math.floor(minutos)) * 60

if (segundos > 0) {
    console.log(`O download irá demorar ${Math.floor(minutos)} minuto(s) e ${Math.round(segundos)} segundo(s)`)
} else {
    console.log(`O download irá demorar ${Math.round(minutos)} minuto(s)`)
}
