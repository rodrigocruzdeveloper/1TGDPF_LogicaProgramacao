using UnityEngine;

public class Exercicio05_Lista02 : MonoBehaviour
{
    /*
    Exercício 5 – Coleta de Moedas 
    Durante uma fase o jogador coletou: 
    • 12 moedas de bronze (valor 1) 
    • 8 moedas de prata (valor 5) 
    • 3 moedas de ouro (valor 10) 
    Problema: 
    Crie variáveis para as quantidades e valores das moedas. 
    Calcule o valor total coletado e imprima no console usando print().
    */



    void Start()
    {
        int bronze = 12 * 1;
        int prata = 8 * 5;
        int ouro = 3 * 10;
        print("Total $: " + (bronze + prata + ouro));
    }
       
}
