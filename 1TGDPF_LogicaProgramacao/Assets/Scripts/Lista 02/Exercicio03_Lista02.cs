using UnityEngine;

public class Exercicio03_Lista02 : MonoBehaviour
{
    /*
    Exercício 3 – Consumo de Mana 
    Um mago possui 100 de mana. 
    Ele utilizou três magias: 
    • Bola de fogo: 30 de mana 
    • Raio elétrico: 20 de mana 
    • Escudo mágico: 25 de mana 
    Problema: 
    Crie variáveis para a mana inicial e para o custo de cada magia. 
    Calcule quanta mana resta após lançar todas as magias e mostre no console usando print().
    */

    void Start()
    {
        int manaInicial = 100;
        int manaUsada = 30 + 20 + 25;
        print("Mana restante:" + (manaInicial - manaUsada));
    }

    
}
