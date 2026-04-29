using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Exercicio08 : MonoBehaviour
{
    /*
   8) Sistema de Dano Dinâmico
    Crie: 
    • public int vida = 100; 
    • public int dano;
    No Start(), diminua a vida pelo dano informado no Inspector e mostre o
    resultado.*/

    public int vida = 100;
    public int dano;

    void Start()
    {
        print("Você tem " + vida + " pontos de vida.");
        print("Você recebeu um dano de " + dano + " agora você tem " + (vida - dano) + "pontos de vida.");
        
    }

   
}
