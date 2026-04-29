using UnityEngine;

public class ConversaoString : MonoBehaviour
{
    string cidade = "São Paulo";

    void Start()
    {
        print(cidade.ToUpper());
        print(cidade.ToLower());
    }
    
}
