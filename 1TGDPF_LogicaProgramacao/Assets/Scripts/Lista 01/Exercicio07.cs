using System;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    /*
    7) Soma com Entrada do Inspector
    Crie duas variáveis públicas(numero1 e numero2). 
    Mostre no Console a soma delas.*/

    public float numero1;
    public float numero2;

    void Start()
    {
        print("Soma das variaveis é: " + (numero1 + numero2));        
    }

}
