using UnityEngine;

public class ExemploFuncoes : MonoBehaviour
{

    // [RETORNO (SAÍDA)]    [NOME] [PARAMETRO DA FUNÇÃO (ENTRADA)]

    private void Start()
    {
        Saudacao();
    }

    void Saudacao()
    {
        string msg = "Bom dia!";
        print(msg);
    }



}
