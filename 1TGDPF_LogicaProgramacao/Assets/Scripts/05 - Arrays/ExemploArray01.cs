using UnityEngine;

public class ExemploArray01 : MonoBehaviour
{
    [SerializeField] private string[] nomes;

    [SerializeField] int[] numeros = new int[10];

    [SerializeField] string[] jogos = new string[] { "Zelda", "Mario", "Sonic" };


    private void Start()
    {
        int i = 0;

        while (i < nomes.Length)
        {
            print(nomes[i]);
            i++;
        }
    }
}
