using System;
using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    /*
    1) Soma Simples
    Crie duas variáveis inteiras(int) chamadas a e b.
    Atribua valores e mostre no Console o resultado da soma.
    Use o operador + e Debug.Log() ou Print().
    */

    int a = 50;
    int b = 100;

    void Start()
    {
        print("A soma de a + b é: " + (a+b));
    }

}
