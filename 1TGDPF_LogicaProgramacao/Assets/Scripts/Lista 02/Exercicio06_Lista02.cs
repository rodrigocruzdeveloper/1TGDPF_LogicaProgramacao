using UnityEngine;

public class Exercicio06_Lista02 : MonoBehaviour
{

    /*
    Exercício 6 – Velocidade do Personagem 
    Um personagem percorreu 120 unidades de distância em 10 segundos. 
    Problema: 
    Crie variáveis para distância e tempo. 
    Calcule a velocidade média do personagem usando a fórmula: 
    velocidade = distancia / tempo 
    Mostre o resultado no console usando print().
    */



    void Start()
    {
        float distancia = 120; 
        float tempo = 10;
        float velocidade = distancia / tempo;
        print("Velocidade: " + velocidade);
    }   
}
