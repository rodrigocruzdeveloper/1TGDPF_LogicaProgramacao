using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    /*
    6) Entrada pelo Inspector 
    Crie uma variável public int idade; 
    No Start(), mostre a idade digitada no Inspector usando Debug.Log(). */

    public int idade;

    void Start()
    {
        print("Idade informada é: " + idade + " anos.");
    }
}
