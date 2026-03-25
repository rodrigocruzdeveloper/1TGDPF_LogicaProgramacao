using UnityEngine;

public class Desafio : MonoBehaviour
{
    [SerializeField] private int numeroJogador;

    private int numeroSecreto;
    private int tentativas;
    private bool jogando;

    private void Start()
    {
        // SINALIZA O INICIO DO JOGO
        jogando = true;

        // GERA O NÚMERO SECRETO PARA O JOGADOR ADIVINHAR
        numeroSecreto = Random.Range(0, 101);
    }

    void Update()
    {
        // LOOPING DO GAME
        if (Input.anyKeyDown && jogando == true)
        {
            // REGISTRA A TENTATIVA
            tentativas++;

            // VERIFICA A COMPARACAO DO VALOR DO JOGADOR COM O NUMERO SORTEADO (SECRETO)
            if(numeroJogador == numeroSecreto)
            {
                print("Acertou. Você venceu!");
                jogando = false;
            }
            else
            {
                if(numeroJogador > numeroSecreto)
                {
                    print("O valor é menor que o escolhido.");
                }
                else
                {
                    print("O valor é maior que o escolhido.");
                }
            }
        }
    }
}
