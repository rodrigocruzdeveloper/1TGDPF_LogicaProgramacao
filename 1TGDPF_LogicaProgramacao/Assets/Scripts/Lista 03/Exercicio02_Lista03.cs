using UnityEngine;

public class Exercicio02_Lista03 : MonoBehaviour
{
    /*
    2. Faça um programa que: 
    a.Receba a idade
    b.Verifique se a pessoa é maior de idade (18+). */

    [SerializeField] private int idade;

    void Start()
    {
        if(idade >= 18)
        {
            print("Maior de idade.");
        }
        else
        {
            print("Menor de idade.");
        }
    }


}
