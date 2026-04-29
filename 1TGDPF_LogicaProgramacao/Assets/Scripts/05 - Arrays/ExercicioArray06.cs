using UnityEngine;

public class ExercicioArray06 : MonoBehaviour
{

    [SerializeField] private int buscar;

    int[] numeros = new int[] {1, 23, 43, 56, 3, 44, 51, 21, 30, 22, 77, 54, 88};

    bool existe;

    void Start()
    {

        int i = 0;

        while (i < numeros.Length)
        {
            if(buscar == numeros[i])
            {                
                existe = true;
                break;
            }

            i++;
        }

        if(existe == false)
        {
            print("Não encontrei o número.");
        }
        else
        {
            print("Número " + buscar + " existe.");
        }

    }
   
}
