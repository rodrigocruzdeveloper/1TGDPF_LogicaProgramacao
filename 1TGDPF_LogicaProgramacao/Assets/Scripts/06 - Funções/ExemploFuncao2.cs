using UnityEngine;

public class ExemploFuncao2 : MonoBehaviour
{

    [SerializeField] private string nome;

    void Start()
    {
        // Saudacao(nome);
        // Somar(10, 5);
        // print(VerificarParImpar(8));

        if(MaiorIdade(21) == true)
        {
            print("Maior");
        }
        else
        {
            print("Menor");
        }


    }
    
    
    bool MaiorIdade(int idade)
    {
        return idade >= 18;
    }






    string VerificarParImpar(int n) 
    { 
        if(n % 2 == 0)
        {
            return "PAR";
        }

        return "IMPAR";

    }


    void Somar(int a, int b)
    {
        int r = a + b;
        print("Resultado: " + r);
    }


    void Saudacao(string n)
    {
        print("Bom dia, " + n + "!");
    }
    
}
