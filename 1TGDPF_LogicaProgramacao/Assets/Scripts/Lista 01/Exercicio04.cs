using Unity.VisualScripting;
using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    /*
    4) Divisão de Recursos
    O jogador tem 50 moedas e precisa dividir entre 5 personagens.
    Calcule quantas moedas cada um recebe.
    Use o operador /. */

    int moedas = 50;

    void Start()
    {
        print("Há " +  moedas + " moedas. Dividindo por 5 personagens, cada um terá: " + (moedas/5) + " moedas.");
    }

}
