using UnityEngine;

public class Exercicio04_Lista02 : MonoBehaviour
{
    /*
    Exercício 4 – Tempo de Missão 
    Um jogador levou os seguintes tempos para completar três partes de uma missão: 
    • Parte 1: 12 minutos 
    • Parte 2: 18 minutos 
    • Parte 3: 9 minutos 
    Problema: 
    Crie variáveis para armazenar os tempos de cada parte. 
    Calcule o tempo total da missão e exiba o resultado no console usando print().
    */

    int parte1 = 12;
    int parte2 = 18;
    int parte3 = 9;

    void Start()
    {
        int tempoTotal = parte1 + parte2 + parte3;
        print("Tempo total da missão: " + tempoTotal);
    }
       
}
