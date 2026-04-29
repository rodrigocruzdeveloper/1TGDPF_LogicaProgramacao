using UnityEngine;

public class ExercicioArray01 : MonoBehaviour
{

    int[] numeros = new int[] { 3, 5, 6, 7, 1 };

    void Start()
    {
        int i = 0;

        while(i < numeros.Length)
        {
            print(numeros[i]);
        }            
    }

    
}
