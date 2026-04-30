using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ExemploCorrotina : MonoBehaviour
{

    int tempo;

    void Start()
    {
        StartCoroutine(ContarTempo());
    }

    IEnumerator ContarTempo()
    {
        // ESPERA PELO DETERMINADO
        /*
        tempo++;
        print(tempo);
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(ContarTempo());
        */

        while(tempo < 60)
        {
            print(tempo);
            tempo++;
            yield return new WaitForSeconds(0.5f);
        }

    }





}
