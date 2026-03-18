using UnityEngine;

public class Exercicio06_Condicional : MonoBehaviour
{

    int jogadorPar;
    int jogadorImpar;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            jogadorImpar = Random.Range(0, 6);
            jogadorPar = Random.Range(0, 6);

            print("Jogador impar: " + jogadorImpar);
            print("Jogador par: " + jogadorPar);

            if((jogadorPar + jogadorImpar) % 2 == 0)
            {
                print("Jogador par venceu.");
            }
            else
            {
                print("Jogador impar venceu.");
            }

        }
    }
}
