using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    [SerializeField] private int a;
    [SerializeField] private int b;

    void Start()
    {
        print("Soma de a + b: " + (a + b));
    }
   
}
