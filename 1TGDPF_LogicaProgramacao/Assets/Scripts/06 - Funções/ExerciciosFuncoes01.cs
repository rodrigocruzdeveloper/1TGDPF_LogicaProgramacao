using UnityEngine;

public class ExerciciosFuncoes01 : MonoBehaviour
{
    /*
     1. Sistema de Boas-Vindas do Jogo 
    Crie um programa em C# para Unity que tenha uma função chamada 
    MostrarMensagem().   
    
    [RETORNO (SAIDA DE DADOS)] [NOME DA FUNÇÃO] [PARAMETROS (ENTRADA DE DADOS)]

     */

    private void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            MostrarMensagem();
        }
    }

    void MostrarMensagem()
    {
        print("Olá, mundo!");
    }

}
