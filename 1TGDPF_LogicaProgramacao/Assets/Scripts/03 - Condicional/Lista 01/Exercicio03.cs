using UnityEngine;


public class Exercicio03 : MonoBehaviour
{
    /*
    3) Multiplicação de Pontos
    Crie uma variável pontos com valor 10. 
    Crie uma variável multiplicador com valor 3. 
    Calcule a pontuação final e mostre no Console.
    Use o operador *.    
    */

    int pontos = 10;
    int multiplicador = 3;

    void Start()
    {
        print("Sua pontuação atual: " + pontos);
        print("Sua pontuação será multiplicada por: " + multiplicador);
        print("Sua pontuação final: " + (pontos * multiplicador));
    }

}
