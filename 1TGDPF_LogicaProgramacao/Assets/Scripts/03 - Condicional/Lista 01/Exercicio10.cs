using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    /*
    10) Aumento Percentual
    Crie uma variável salario = 1000f.
    Aumente 10% no salário e mostre o valor final.
    Dica: 
    salario + (salario* 0.10f) */

    public float salario = 1000.0f;

    void Start()
    {
        print("Salario atual: " + salario);
        print("Com aumento de 10%: " + (salario + (salario * 0.10f)));
    }

   
}
