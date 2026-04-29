using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    [Header("Número estará entre 0 até 50")]
    [SerializeField] private bool facil;

    [Header("Número estará entre 0 até 100")]
    [SerializeField] private bool medio;

    [Header("Número estará entre 0 até 500")]
    [SerializeField] private bool dificil;


    [Header("ESCOLHA UM NÚMERO")]
    [SerializeField] private int numeroJogador;
    
    
    private int numeroSecreto;
    private int tentativas;
    private bool jogando;

    private void Start()
    {
        // DETERMINA O NÚMERO MÁXIMO DE TENTATIVAS
        tentativas = 3;

        // SINALIZA O INICIO DO JOGO
        jogando = true;

        // GERA O NÚMERO SECRETO PARA O JOGADOR ADIVINHAR
        if (facil)
        {
            numeroSecreto = Random.Range(0, 51);            
        }
        else if (medio)
        {
            numeroSecreto = Random.Range(0, 101);
        }
        else if (dificil)
        {
            numeroSecreto = Random.Range(0, 501);
        }
        else
        {
            print("Selecione a dificuldade;");

            // RETORNA O VALOR DA VARIAVEL PARA QUE O JOGO NAO RODE ATE ESCOLHER A DIFICULDADE
            jogando = false;
        }

        
    }

    void Update()
    {
        // LOOPING DO GAME E REGRA PARA CONTINUIDADE DO JOGO
        if (Input.anyKeyDown && jogando == true && tentativas > 0)
        {
            // REGISTRA A TENTATIVA
            tentativas--;
            print("Tentativas restantes: " + tentativas);

            // VERIFICA A COMPARACAO DO VALOR DO JOGADOR COM O NUMERO SORTEADO (SECRETO)
            if (numeroJogador == numeroSecreto)
            {
                print("Acertou. Você venceu!");
                jogando = false;
            }
            else
            {
                // O JOGADOR NAO ACERTOU E AQUI SERA DADO DICAS
                if (numeroJogador > numeroSecreto)
                {
                    print("O valor é menor que o escolhido.");
                }
                else
                {
                    print("O valor é maior que o escolhido.");
                }

                // DICA DO INTERVALO QUANDO RESTA SO UMA TENTATIVA
                if(tentativas == 1)
                {
                    // DETERMINA O INTERVALO MINIMO
                    int valorMinimo = numeroSecreto - 5;

                    if(valorMinimo < 0)
                    {
                        valorMinimo = 0;
                    }

                    // DETERMINA O INTERVALO MAXIMO
                    int valorMaximo = numeroSecreto + 5;

                    if( valorMaximo > 100)
                    {
                        valorMaximo = 100;
                    }
                }

            }
        }
    }
}
