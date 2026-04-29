using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class Exercicio12 : MonoBehaviour
{
    /*
    12) Sistema de Pontuação Completo
    Crie: 
    • public int pontosBase; 
    • public int inimigosDerrotados; 
    • public int bonus;
        Calcule: 
    pontuacaoFinal = (pontosBase* inimigosDerrotados) + bonus; 
    Mostre o resultado no Console. */

    public int pontosBase;
    public int inimigosDerrotados;
    public int bonus;

    void Start()
    {
        print("Pontos: " + pontosBase);
        print("Inimigos derrotados: " + inimigosDerrotados);
        print("Bonus: " + bonus);

        int pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;

        print("Pontuação final: " + pontuacaoFinal);
    }

}
