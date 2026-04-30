using UnityEngine;

public class ExerciciosFuncoes02 : MonoBehaviour
{
    /*2. Cadastro de Personagem 
    Crie um programa em C# para Unity com uma função chamada 

    MostrarPersonagem(string nome)  
    
    Requisitos: 
    • A função deve receber um parâmetro do tipo string.  
    • A função não deve retornar valor.  
    • O usuário deve informar o nome de um personagem.  
    • A função deve exibir no console: “Personagem criado: nomeDigitado”.  
    • Utilize ToUpper() para mostrar o nome em letras maiúsculas. */

    [SerializeField] private string personagem;

    void MostrarPersonagem(string nome)
    {
        print("Personagem criado: " + nome.ToUpper());
    }


    void Start()
    {
        MostrarPersonagem(personagem);
    }

}
