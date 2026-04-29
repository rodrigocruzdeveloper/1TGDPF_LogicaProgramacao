using UnityEngine;

public class ExemploFuncao3 : MonoBehaviour
{

    private void Update()
    {
        print(Mostrar_X());
    }

    float Mostrar_X()
    {
        return transform.position.x;
    }

}
