using UnityEngine;

public class Exercicio01_Lista02 : MonoBehaviour
{
    /*
    Exercício 1 – Pontos de Experiência do Personagem 
    Um personagem derrotou 3 inimigos pequenos, 2 inimigos médios e 1 inimigo chefe. 
    • Cada inimigo pequeno concede 10 XP. 
    • Cada inimigo médio concede 25 XP. 
    • O chefe concede 100 XP. 
    Problema: 
    Crie variáveis para armazenar a quantidade de inimigos derrotados e o XP de cada tipo. 
    Calcule o XP total ganho pelo personagem e mostre o resultado no console usando print().
     */
        

    void Start()
    {
        int inimigosDerrotados = (3 * 10) + (2 * 25) + (1 * 100);
        print("Valor total: " + inimigosDerrotados);
    }

    
}
