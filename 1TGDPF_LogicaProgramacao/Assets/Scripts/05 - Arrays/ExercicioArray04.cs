using UnityEngine;

public class ExercicioArray04 : MonoBehaviour
{
    int[] numeros = new int[100];

    void Start()
    {
        int i = 0;
        int pares = 0;

        while (i < numeros.Length)
        {
            numeros[i] = Random.Range(1, 1000);

            if(numeros[i] % 2 == 0)
            {                
                pares++;
                print(pares + " - " + numeros[i]);
            }

            i++;
        }

        print("Quantidade de números pares: " + pares);
    }   
}
