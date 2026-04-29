using UnityEngine;

public class ExercicioArray02 : MonoBehaviour
{
    float[] numeros = new float[] {10, 20, 55, 31};

    void Start()
    {
        float total = 0;
        int i = 0;

        while(i < numeros.Length)
        {
            total += numeros[i];
            i++;
        }

        print("Total: " + total);

    }    
}
