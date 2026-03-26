using UnityEngine;

public class Exercicio01_Lista06 : MonoBehaviour
{
    /*
    Desarme a Bomba 
    
    Crie um jogo onde: 
    • O jogador deve escolher um número de 1 a 3  
    • Apenas um número correto desarma a bomba (ex: 2)  
    Use condicional: 
    • Se acertar → "Bomba desarmada!"  
    • Se errar → "BOOM! Você perdeu!" 
    
    Extra: mostre uma mensagem diferente para cada escolha errada.
    */

    [Header("Digite um valor de 1 até 3")]
    [SerializeField] private int numeroJogador;

    private int numeroBomba;

    void Start()
    {
        // GERA UM NÚMERO ALEATORIO DE 1 ATE 3 QUE SIMBOLIZA O CODIGO PARA DESARMAR A BOMBA
        numeroBomba = Random.Range(1, 4);
    }
       
    void Update()
    {
        // EXECUTAR A VERIFICAÇÃO QUANDO QUALQUER TECLA FOR PRESSINADA
        if (Input.anyKeyDown)
        {
            // VERIFICA SE O NÚMERO INFORMADO PELO JOGADOR É VÁLIDO
            if (numeroJogador >= 1 && numeroJogador <= 3)
            {
                // VERIFICA SE DESARMOU A BOMBA
                if (numeroJogador == numeroBomba)
                {
                    print("Bomba desarmada!");
                }
                else
                {
                    // GERA UM NÚMERO ALEATÓRIO PARA ESCOLHER UMA MENSAGEM
                    int mensagem = Random.Range(1, 4);

                    // EMITE A MENSAGEM DE ACORDO COM O VALOR GERADO NA VARIAVEL MENSAGEM
                    if(mensagem == 1)
                    {
                        print("BOOM! Você perdeu!");
                    }
                    else if(mensagem == 2)
                    {
                        print("A bomba explodiu!");
                    }
                    else if(mensagem == 3)
                    {
                        print("Você perdeu, a bom explodiu.");
                    }                   
                }
            }
            else
            {
                // AVISA QUE O NÚMERO INFORMADO NÃO É VALIDO
                print("Número informado deve estar entre 1 e 3.");
            }
        }
    }
}
