using UnityEngine;

public class Exemplo05_Condicional : MonoBehaviour
{

    int numero1 = 100;
    int numero2 = 50;  

    void Start()
    {
        if (numero1 > numero2)
        {
            print(numero1 + " é maior que o " + numero2);
        }
        else if (numero2 > numero1)
        {
            print(numero2 + " é maior que o " + numero1);
        }
        else if(numero1 == numero2)
        {
            print("São iguais.");
        }
    }    
}
