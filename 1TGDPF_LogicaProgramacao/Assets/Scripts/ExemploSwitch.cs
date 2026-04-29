using UnityEngine;

public class ExemploSwitch : MonoBehaviour
{

    [SerializeField] int opcao;

    /*
        0 - ENTRAR NO JOGO
        1 - CONFIGUAÇÕES
        2 - SAIR
    */

    void Start()
    {
        switch (opcao)
        {
            case 0:
                print("ENTRAR NO JOGO");
                break;

            case 1:
                print("MENU DE CONFIGURAÇÕES");
                break;
            case 2:
                print("SAIR DO JOGO");
                break;
            default:
                print("OPÇÃO INVÁLIDA.");
                break;
        }

    }

   
   
}
