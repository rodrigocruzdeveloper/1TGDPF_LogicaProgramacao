using UnityEngine;

public class ExercicioArray05 : MonoBehaviour
{
    string[] livros = new string[] {"Mágico OZ", "Neuromancer", "Monalisa Overdrive", "Count Zero", "Alice", "Vinte mil leguas submarinas" };


    void Start()
    {
        int i = livros.Length - 1;

        while(i > 0)
        {
            print(livros[i]);
            i--;
        }

    }

    
}
