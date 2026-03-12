using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio09 : MonoBehaviour
{
    /*
    9) Dobro e Metade
    Crie uma variável numero.
    Mostre: 
    • O dobro do número.
    • A metade do número. */

    public int numero;

    void Start()
    {
        print("O dobro de " + numero + " é: " + (numero * 2));
        print("A metade de " + numero + " é: " + (numero / 2));
    }

}
