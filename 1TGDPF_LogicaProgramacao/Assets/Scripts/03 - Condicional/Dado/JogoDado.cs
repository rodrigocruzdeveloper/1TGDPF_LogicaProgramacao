using UnityEngine;

public class JogoDado : MonoBehaviour
{

    int placarJogador1;
    int dadoJogador1;

    int placarJogador2;
    int dadoJogador2;

    bool jogando = true;

    void Update()
    {
        // SE QUALQUER TECLA FOR PRESSIONADA EXECUTA O CODIGO DENTRO IF
        if (Input.anyKeyDown && jogando == true)
        {
            // JOGO ACONTECENDO

            // JOGA O DADO GERANDO NÚMEROS ALEATÓRIOS DE 1 ATE 6
            dadoJogador1 = Random.Range(1, 7);
            dadoJogador2 = Random.Range(1, 7);

            // EXIBE OS NÚMEROS GERADOS PELOS DADOS
            print("Dado do jogador 1: " + dadoJogador1);
            print("Dado do jogador 2: " + dadoJogador2);

            // VERIFICAR A RODADA
            if (dadoJogador1 == dadoJogador2)
            {
                print("Empate.");
            }
            else
            {
                if(dadoJogador1 > dadoJogador2)
                {
                    // JOGADOR 1 VENCEU
                    placarJogador1++;
                    print("Jogador 1 venceu a rodada.");
                }
                else
                {
                    // JOGADOR 2 VENCEU
                    placarJogador2++;
                    print("Jogador 2 venceu a rodada.");
                }

                if(placarJogador1 == 3 || placarJogador2 == 3)
                {
                    jogando = false;
                }

            }

            print("Placar");
            print("Jogador 1:" + placarJogador1);
            print("Jogador 2:" + placarJogador2);

            print("--------------------------");

            if (jogando == false)
            {
                // FIM DO JOGO
                if (placarJogador1 > placarJogador2)
                {
                    print("Jogadro 1 venceu o jogo.");
                }
                else
                {
                    print("Jogadro 2 venceu o jogo.");
                }
                print("Fim.");
            }
        }
    }
}
