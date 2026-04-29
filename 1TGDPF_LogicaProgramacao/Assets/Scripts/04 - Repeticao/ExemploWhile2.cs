using UnityEngine;

public class ExemploWhile2 : MonoBehaviour
{
    [SerializeField] private int quantidade;

    
    void Start()
    {
        int a = 0;

        while (a < quantidade)
        {
            print(a + " - " + Random.Range(1, 101));
            a++;
        }        
    }
        
}
