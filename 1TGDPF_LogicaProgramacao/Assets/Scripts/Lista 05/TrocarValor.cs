using UnityEngine;

public class TrocarValor : MonoBehaviour
{

    [SerializeField] private int numero;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            print("Número: " + numero);
        }
    }
}
