using UnityEngine;

public class ExemploFor03 : MonoBehaviour
{
    [SerializeField] private string buscar;

    string[] nomes = new string[] {"Carol", "Ana", "Maria", "Eduardo"};

    void Start()
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i].ToUpper() == buscar.ToUpper())
            {
                print(nomes[i]);
            }            
        }
    }

    
}
