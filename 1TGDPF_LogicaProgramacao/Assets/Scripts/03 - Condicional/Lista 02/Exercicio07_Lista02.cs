using UnityEngine;

public class Exercicio07_Lista02 : MonoBehaviour
{
    /*
    Exercício 7 – Vida Restante do Personagem 
    Um personagem possui 150 pontos de vida. 
    Durante uma batalha ele recebeu os seguintes danos: 
        • Ataque do inimigo 1: 20 
        • Ataque do inimigo 2: 35 
        • Ataque do inimigo 3: 15 
    Problema: 
    Crie variáveis para a vida inicial e para os danos recebidos. 
    Calcule quanta vida resta ao personagem e exiba o resultado no console usando print().
    */

    void Start()
    {
        int vidaPersonagem = 150;
        int danos = 20 + 35 + 15;
        print("Vida restante: " + (vidaPersonagem - danos));
    }   
}
