using UnityEngine;

public class ExerciciosFuncoes03 : MonoBehaviour
{
    /*3. Cálculo de Dano do Ataque 
    
    Crie um programa em C# para Unity com uma função chamada 
    CalcularDano(int ataque, int defesa).  
   
    Requisitos: 
    • A função deve receber dois parâmetros inteiros.  
    • A função deve retornar um valor inteiro.  
    • O dano será calculado por: ataque - defesa.  
    • Se o resultado for menor que 0, retornar 0.  
    • No Start(), exiba o valor final do dano usando print(). */

    private void Start()
    {
        print(CalcularDano(1, 3));
    }


    int CalcularDano(int ataque, int defesa)
    {
        if((ataque - defesa) < 0)
        {
            return 0;
        }

        return ataque - defesa;
    }

}
