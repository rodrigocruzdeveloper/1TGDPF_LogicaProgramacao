using UnityEngine;

public class Exercicio02_Lista02 : MonoBehaviour
{
    /*
    Exercício 2 – Dano Total do Ataque 
    Um personagem possui um ataque que causa 15 de dano base. 
    Durante o combate aconteceram os seguintes bônus: 
    • Um bônus de arma que adiciona 5 de dano 
    • Um bônus temporário que multiplica o dano por 2 
    Problema: 
    Crie variáveis para os valores do dano base e dos bônus. 
    Calcule o dano final do ataque e imprima o resultado no console usando print().
     */

    void Start()
    {
        int dano = (15 + 5) * 2;
        print("Dano final: " + dano);
    }

    
}
