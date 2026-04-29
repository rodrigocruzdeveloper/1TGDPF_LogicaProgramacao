using UnityEngine;

public class ExercicioArray03 : MonoBehaviour
{
    int[] numeros = new int[] {10, 5, 3, 17, 1, 3, 71, 42};

    void Start()
    {
        int i = 0;
        int maior = 0;

        while (i < numeros.Length)
        {
            if(maior < numeros[i])
            {
                maior = numeros[i];
            }

            i++;
        }

        print(maior);
    }
  
}
