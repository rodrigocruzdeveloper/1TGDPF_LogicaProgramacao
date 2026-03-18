using UnityEngine;

public class Exemplo02_Condicional : MonoBehaviour
{
    [SerializeField] private string aluno;
    [SerializeField] private float nota1;
    [SerializeField] private float nota2;
    [SerializeField] private float nota3;
        
    void Start()
    {
        float media = (nota1 + nota2 + nota3) / 3;

        print("Média final: " + media);

        if (media >= 6.0f)
        {
            print(aluno + " você foi aprovado.");
        }
        else
        {
            print(aluno + " você foi reprovado. Ahahah!!!");
        }
        
    }   
}
