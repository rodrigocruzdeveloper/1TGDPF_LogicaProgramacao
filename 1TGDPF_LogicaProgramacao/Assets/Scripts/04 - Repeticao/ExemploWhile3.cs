using UnityEngine;

public class ExemploWhile3 : MonoBehaviour
{

    [SerializeField] private GameObject triangulo;
    [SerializeField] private int quantidade;

    void Start()
    {
        int a = 0;

        while (a < quantidade)
        {
            GameObject clone = Instantiate(triangulo);
            clone.transform.position = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-3.0f, 3.0f));

            byte r = (byte)Random.Range(0, 255);
            byte g = (byte)Random.Range(0, 255);
            byte b = (byte)Random.Range(0, 255);

            Color32 cor = new Color(r, g, b, 255);

            clone.GetComponent<SpriteRenderer>().color = cor;

            a++;
        }
    }
       
}
