using UnityEngine;

public class Exercicio02_Lista06 : MonoBehaviour
{
    /*
      Corrida Simples 
    Simule uma corrida entre dois jogadores: 
    • velocidade_jogador1 = 10  
    • velocidade_jogador2 = 8  
    Use condicionais para verificar: 
    • Quem é mais rápido → "Jogador 1 venceu!" ou "Jogador 2 venceu!"  
    • Se forem iguais → "Empate!"  
    Extra: peça valores ao usuário.
    */

    [SerializeField] private int velocidadeJogador1;
    [SerializeField] private int velocidadeJogador2;
       
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if(velocidadeJogador1 == velocidadeJogador2)
            {
                print("Empate.");
            }
            else
            {
                if(velocidadeJogador1 > velocidadeJogador2)
                {
                    print("Jogadro 1 venceu.");
                }
                else
                {
                    print("Jogador 2 venceu.");
                }
            }
        }        
    }
}
