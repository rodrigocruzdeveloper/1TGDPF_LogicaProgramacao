using UnityEngine;

public class ExemploArray02 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[10];

    void Start()
    {
        int i = 0;

        while(i < numeros.Length)
        {
            numeros[i] = Random.Range(1, 1000);
            i++;
        }
    }
    
}
