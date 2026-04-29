using UnityEngine;

public class GuerraDados : MonoBehaviour
{
    [Header("Player - Atribua pontos sendo a soma 5")]
    [SerializeField] private int jogadorVida;
    [SerializeField] private int jogadorAtaque;
    [SerializeField] private int jogadorDefesa;
    private int dadoJogadorAcao;
    private int dadoJogadorPotencia;
    private bool jogando;
    private int jogadorDano;
    private int jogadorDefesaTemp;


    private int cpuVida;
    private int cpuAtaque;
    private int cpuDefesa;
    private int cpuPontos;
    private int dadoCpuAcao;
    private int dadoCpuPontencia;
    private int cpuDano;
    private int cpuDefesaTemp;

    void Start()
    {   
        // FAZ A CHECAGEM SE OS PONTOS DO JOGADOR ESTÃO COERENTES
        if((jogadorVida + jogadorAtaque + jogadorDefesa) == 5)
        {
            jogando = true;
            print("Prepare-se para o inicio da batalha.");
        }
        else
        {
            print("Distribuição de pontos inválida.");
        }


        // EXECUTA A DISTRIBUICAO DE PONTOS NA CPU SOMENTE SE O JOGADOR ESTIVER VALIDO
        if (jogando == true)
        {
            // DESTRIBUI OS PONTOS PARA CPU
            cpuPontos = 5;

            // SORTEIA O VALOR PARA VIDA CPU
            cpuVida = Random.Range(1, cpuPontos + 1);

            // EVITA QUE FALTE PONTOS PARA OS OUTROS ATRIBUTOS
            if (cpuVida > 3)
            {
                cpuVida = 3;
            }

            // REMOVE OS PONTOS USADOS PARA VIDA DA CPU
            cpuPontos = cpuPontos - cpuVida;

            // VALIDA OS OUTROS ATRIBUTOS DE ACORDO COM O QUE SOBROU DE PONTOS
            if (cpuPontos == 3)
            {
                // ENTENDO QUE SOBROU APENAS 2 PONTOS FAÇA A DISTRIBUICAO DE 1 PONTO PARA CADA ATRIBUTO
                cpuAtaque = 1;
                cpuDefesa = 1;
            }
            else
            {
                // SE SOUBROU ACIMA DE 2 PONTOS FAZ A DISTRIBUICAO ENTRE OS DEMAIS ATRIBUITOS
                cpuAtaque = Random.Range(1, cpuPontos + 1);

                // REMOVE OS PONTOS ATRIBUIDOS NO ATRIBUTO DE ATAQUE
                cpuPontos = cpuPontos - cpuAtaque;

                // ATRIBUI OS PONTOS QUE RESTARAM PARA DEFESA
                cpuDefesa = cpuPontos;
            }
        }    
    }

   
    void Update()
    {
        // VALIDA SE O JOGO PODE ACONTECER
        if (jogando == true)
        {
            // DISPARA UM TURNO A CADA TOQUE NA TECLA
            if(Input.anyKeyDown && (cpuVida > 0 && jogadorVida > 0))
            {
                // RODA OS DADOS PARA O TURNO

                // CPU
                dadoCpuAcao = Random.Range(1, 7);
                dadoCpuPontencia = Random.Range(1, 7);

                // JOGADOR
                dadoJogadorAcao = Random.Range(1, 7);
                dadoJogadorPotencia = Random.Range(1, 7);

                // VERIFICA A ACAO SE AMBOS ESTAO DEFENDENDO (ANULA O TURNO)
                if(dadoCpuAcao % 2 != 0 && dadoJogadorAcao % 2 != 0)
                {
                    print("Ambos defenderam, turno anulado.");
                }
                else
                {
                    // PROCESSAMENTO DA CPU
                    if (dadoCpuAcao % 2 == 0)
                    {
                        // ATAQUE
                        cpuDano = cpuDano + dadoCpuPontencia;
                    }
                    else
                    {
                        // DEFESA
                        cpuDefesaTemp = cpuDefesa + dadoCpuPontencia;
                    }

                    // PROCESSAMENTO DO JOGADOR
                    if (dadoJogadorAcao % 2 == 0)
                    {
                        // ATAQUE
                        jogadorDano = cpuDano + dadoCpuPontencia;
                    }
                    else
                    {
                        // DEFESA
                        cpuDefesaTemp = cpuDefesa + dadoCpuPontencia;
                    }

                    // DEFINIÇÃO DO TURNO

                    // ATAQUE (CPU) E ATAQUE (JOGADOR)
                    if(dadoCpuAcao % 2 == 0 && dadoJogadorAcao % 2 == 0)
                    {
                        print("Ambos atacaram");

                        if (cpuDano > jogadorDano)
                        {
                            cpuDano = cpuDano - jogadorDano;    
                            jogadorVida = jogadorVida - cpuDano;
                        }
                        else if(jogadorDano > cpuDano)
                        {
                            jogadorDano = jogadorDano - cpuDano;
                            cpuVida = cpuVida - jogadorDano;
                        }
                    }
                    // ATAQUE (CPU ATAQUE) E DEFESA (JOGADOR)
                    else if (dadoCpuAcao % 2 == 0 && dadoJogadorAcao % 2 != 0)
                    {
                        print("CPU atacou o jogador");

                        cpuDano = cpuDano - jogadorDefesa;
                        jogadorVida = jogadorVida - cpuDano;
                    }
                    // ATAQUE (JOGADOR) E DEFESA (CPU)
                    else if (dadoCpuAcao % 2 == 0 && dadoJogadorAcao % 2 != 0)
                    {
                        print("Jogador atacou a CPU");
                        jogadorDano = jogadorDano - cpuDefesa;
                        cpuVida = cpuVida - jogadorDano;
                    }

                    // PARTIDA ACABOU?
                    if(jogadorVida <= 0 || cpuVida <= 0)
                    {
                        if(jogadorVida > 0)
                        {
                            print("Jogador, venceu.");
                        }
                        else
                        {
                            print("CPU, venceu.");
                        }
                    }
                    else
                    {                       
                        print("Jogador: " + jogadorVida);
                        print("CPU: " + cpuVida);
                    }
                }
            }
        }
    }
}
