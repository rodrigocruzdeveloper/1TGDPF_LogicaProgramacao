using UnityEngine;

public class Exercicio04_Lista03 : MonoBehaviour
{
    /*
      4. Peça dois números e: 
        a. Verifique se eles são iguais ou diferentes.
     */

    [SerializeField] private int numero1 = 5;
    [SerializeField] private int numero2 = 7;
    
    void Start()
    {
        if(numero1 == numero2)
        {
            print(numero1 + " é igual ao " + numero2);
        }
        else
        {
            print(numero1 + " é diferente que " + numero2);
        }
    }

  
}
