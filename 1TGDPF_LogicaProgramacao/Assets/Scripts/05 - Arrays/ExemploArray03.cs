using UnityEngine;

public class ExemploArray03 : MonoBehaviour
{
    [SerializeField] string[] jogos = new string[] {"Zelda", "Mario", "Sonic"};
    
    void Start()
    {
        print(jogos[1]);

        jogos[1] = "Kirby";

        print(jogos[1]);
    }
        
}
