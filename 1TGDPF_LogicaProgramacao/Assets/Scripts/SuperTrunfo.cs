using UnityEngine;

public class SuperTrunfo : MonoBehaviour
{
    int[] cartaJogador1 = new int[3]; 
    int[] cartaJogador2 = new int[3];

    int pontosJogador1;
    int pontosJogador2;

    int atributo;
    int rodadas;

    private void Start()
    {        
        rodadas = 0;
        pontosJogador1 = 0;
        pontosJogador2 = 0;
    }


    void Update()
    {
        if (Input.anyKeyDown && rodadas < 5)
        {
            // REGISTRA A RODADA
            rodadas++;

            // SORTEIRA O ATRIBUTO PARA A RODADA ATUAL
            /*
            0 - força
            1 - velocidade
            2 - inteligência
            */
            atributo = Random.Range(0, 3);

            // SORTEIA AS CARTAS DOS JOGADORES - ATRIBUTOS DAS CARTAS COM VALORES DE 1 ATÉ 9
            for (int i = 0; i < 3; i++)
            {
                cartaJogador1[i] = Random.Range(1, 10);
                cartaJogador2[i] = Random.Range(1, 10);
            }

            // DEFINIR O RESULTADO DA RODADA
            if(atributo == 0)
            {
                // FORÇA
                if (cartaJogador1[0] == cartaJogador2[0])
                {
                    print("Empate.");
                }
                else
                {
                    if (cartaJogador1[0] > cartaJogador2[0])
                    {
                        pontosJogador1++;
                    }
                    else
                    {
                        pontosJogador2++; 
                    }
                }                                
            }
            else if(atributo == 1)
            {
                // VELOCIDADE
                if (cartaJogador1[1] == cartaJogador2[1])
                {
                    print("Empate.");
                }
                else
                {
                    if (cartaJogador1[1] > cartaJogador2[1])
                    {
                        pontosJogador1++;
                    }
                    else
                    {
                        pontosJogador2++;
                    }
                }
            }
            else if(atributo ==2)
            {
                // INTELIGENCIA
                if (cartaJogador1[2] == cartaJogador2[2])
                {
                    print("Empate.");
                }
                else
                {
                    if (cartaJogador1[2] > cartaJogador2[2])
                    {
                        pontosJogador1++;
                    }
                    else
                    {
                        pontosJogador2++;
                    }
                }
            }

            // EXBIR A RODADA
            print("Rodada: " + rodadas);

            // RESULTADO
            if (atributo == 0)
            {
                print("Atributo: Força");
            }
            else if (atributo == 1)
            {
                print("Atributo: Velocidade");
            }
            else if(atributo == 2)
            {
                print("Atributo: Inteligência");
            }

            // EXIBE O VALOR DA CARTA
            print("Carta do jogador 1:" + cartaJogador1[atributo]);
            print("Carta do jogador 2:" + cartaJogador2[atributo]);

            // PONTUAÇÃO ATUAL
            print("Jogador 1: " + pontosJogador1);
            print("Jogador 2: " + pontosJogador2);

            print("--------------------------------");
        }
        else if(rodadas == 5) 
        {
            print("--------------------------------");

            rodadas++;

            if(pontosJogador1 == pontosJogador2)
            {
                print("Empataram.");
            }
            else
            {
                if(pontosJogador1 > pontosJogador2)
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
}
