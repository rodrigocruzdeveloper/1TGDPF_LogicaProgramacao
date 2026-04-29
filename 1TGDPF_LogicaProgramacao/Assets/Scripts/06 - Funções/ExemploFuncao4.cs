using UnityEngine;

public class ExemploFuncao4 : MonoBehaviour
{
    [SerializeField] private int ladosDoDado;

    int valorDadoJogador1;
    int valorDadoJogador2;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            valorDadoJogador1 = Dado(ladosDoDado);
            valorDadoJogador2 = Dado(ladosDoDado);

            if(valorDadoJogador1 == valorDadoJogador2)
            {
                print("Emapte.");
            }
            else
            {
                if(valorDadoJogador1 > valorDadoJogador2)
                {
                    print("Jogador 1, venceu.");
                }
                else
                {
                    print("Jogador 2, venceu.");
                }
            }

        }
    }

    int Dado(int lados)
    {
        return Random.Range(1, lados + 1);
    }



}
