using UnityEngine;

public class Exercicio03_Lista03 : MonoBehaviour
{
    /*
    3. Crie um programa que: 
    a. Receba a um número 
    b. Mostre se ele  é par ou impar.
    */

    [SerializeField] private int numero;

    void Start()
    {
        if(numero % 2 == 0)
        {
            print(numero + " é par.");
        }
        else
        {
            print(numero + " impar.");
        }
    }
        
}
