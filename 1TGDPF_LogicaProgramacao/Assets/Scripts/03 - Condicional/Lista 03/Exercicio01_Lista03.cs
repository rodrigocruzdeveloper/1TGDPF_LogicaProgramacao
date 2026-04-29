using UnityEngine;

public class Exercicio01_Lista03 : MonoBehaviour
{
    /*
    1. Crie um programa que: 
    a. Receba dois números 
    b. Mostre qual deles é maior.
    */

    [SerializeField] private int numero1;
    [SerializeField] private int numero2;

    void Start()
    {
        if(numero1 > numero2)
        {
            print(numero1 + " é maior que " + numero2);
        }
        else
        {
            print(numero2 + " é maior que " + numero1);
        }
    }
       
}
