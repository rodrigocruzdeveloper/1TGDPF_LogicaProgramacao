using UnityEngine;

public class Exercicio03_Lista06 : MonoBehaviour
{
    /*
    Loja do Jogo 
    Simule uma loja onde o jogador pode comprar um item: 
    • moedas = 50  
    • Itens:  
    o Espada ? 30 moedas  
    o Armadura ? 40 moedas  
    o Poção ? 10 moedas  
    Use condicionais para: 
    • Verificar se o jogador tem moedas suficientes  
    • Se tiver ? descontar e confirmar compra  
    • Se não ? "Moedas insuficientes!"  
    Extra: 
    • Aplique desconto se o jogador tiver mais de 100 moedas  
    • Permita escolher mais de um item (sem usar loops ainda, apenas lógica repetida)
    */

    [SerializeField] private int moedas;

    [SerializeField] private bool espada;
    [SerializeField] private bool armadura;
    [SerializeField] private bool pocao;

    private int VALORESPADA = 30;
    private int VALORARMADURA = 40;
    private int VALORPOCAO = 10;
    
    void Start()
    {

        // VERIFICA A COMPRA FEITA PELO JOGADOR
        int totalCompra = 0;

        if (espada)
        {
            totalCompra += VALORESPADA;
        }
        
        if (armadura)
        {
            totalCompra += VALORARMADURA;
        }

        if (pocao)
        {
            totalCompra += VALORPOCAO;
        }

        // VERIFICA SE ELE PODE PAGAR
        if(moedas >= totalCompra)
        {
            if(moedas > 100)
            {
                // COMPRA COM DESCONTO
                totalCompra -= 10;
                moedas -= totalCompra;
            }
            else
            {
                // COMPRA SEM DESCONTO
                moedas -= totalCompra;               
            }

            print("Compra efetuada. Restou " + moedas + " moedas");

        }
        else
        {
            print("Moedas insuficientes para compra.");
        }
    }
        
}
