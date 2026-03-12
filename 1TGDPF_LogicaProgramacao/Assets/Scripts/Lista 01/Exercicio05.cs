using NUnit.Framework.Internal;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercicio05 : MonoBehaviour
{
    /*
    5) Resto da Divisão(Módulo)
    Crie um código que mostre o resto da divisão de 17 por 4. 
    Use o operador %. */

    int a = 17;
    int b = 4;

    void Start()
    {
        print("O resto da divisão de 17/4 é: " + (a % b));
    }

}
