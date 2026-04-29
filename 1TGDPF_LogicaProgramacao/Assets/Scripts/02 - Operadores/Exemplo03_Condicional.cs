using UnityEngine;

public class Exemplo03_Condicional : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKey)
        {
            print("Tecla pessionada.");
        }        
    }
}
