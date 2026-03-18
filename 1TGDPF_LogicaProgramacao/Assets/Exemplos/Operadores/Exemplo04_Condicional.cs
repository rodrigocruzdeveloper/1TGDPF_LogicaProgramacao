using UnityEngine;

public class Exemplo04_Condicional : MonoBehaviour
{
    /*
        1 - BARBARO
        2 - MAGO
        3 - PALADINO
        4 - ARQUEIRO
    */

    [SerializeField] private int classePersonagem;

    void Start()
    {
        if(classePersonagem == 1)
        {
            print("Você escolheu o barbaro");
        }
        else if(classePersonagem == 2)
        {
            print("Você escolheu o mago");
        }
        else if(classePersonagem == 3)
        {
            print("Você escolheu o paladino");
        }
        else if(classePersonagem == 4)
        {
            print("Você escolheu o arqueiro");
        }
        else
        {
            print("Classe não existe.");
        }
    }   
}
