using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{

    private string[] guerreiros = {"Golias", "Gepeto", "Conan", "Charles", "Amazonas"};
    private int[] vidaGuerreiros = {100, 100, 100, 100, 100};
    private int[] ataqueGuerreiros = new int[5];

    [SerializeField] private string jogador = "Nicole";
 
    void Start()
    {
        // EXIBE OS GUERREIROS QUE IRÃO PARTICIPAR DAS BATALHAS
        print("Guerreiros que irão batalhar");

        int i = 0;

        foreach (string guerreiro in guerreiros)
        {
            ataqueGuerreiros[i] = Random.Range(1, 101);
            print("Jogador: " + guerreiro + " | Vida: " + vidaGuerreiros[i] + " | Ataque: " + ataqueGuerreiros[i]);
            i++;
        }

        print("------------------------------");


        // LOGICA DAS BATALHAS
        int batalhaAtual = 0;

        while (batalhaAtual < guerreiros.Length)
        {
            // LOOPING DAS BATALHAS
            print("Batalha número: " + batalhaAtual);

            // DADOS DO GUERREIRO
            int vidaGuerreiro = vidaGuerreiros [batalhaAtual];
            int ataqueGuerreiro = ataqueGuerreiros[batalhaAtual];
            string guerreiroAtual = guerreiros[batalhaAtual];

            // DADOS DO JOGADOR
            int vidaJogador = 100;
            int ataqueJogador = Random.Range(1, 101);

            // GUERREIRO ATUAL
            print("Jogador: " + guerreiros[batalhaAtual] + " | Vida: " + vidaGuerreiro + " | Ataque: " + ataqueGuerreiro);

            // JOGADOR
            print("Jogador: " + jogador + " | Vida: " + vidaJogador + " | Ataque: " + ataqueJogador);

            // APURAR O RESULTADO DA BATALHA
            if(ataqueJogador == ataqueGuerreiro)
            {
                print("Empate. Niguém venceu, segue para próxima batalha.");
            }
            else
            { 
                if(ataqueJogador > ataqueGuerreiro)
                {
                    vidaGuerreiro = 0;
                }
                else
                {
                    vidaJogador = 0;
                }
            }

            // EXIBIR O RESULTADO FINAL DA BATALHA
           
            
            switch (vidaJogador)
            {
                case 0:
                    print(guerreiros[batalhaAtual] + ", venceu.");
                    break;
                default:
                    print(jogador + ", venceu.");
                    break;
            }


            batalhaAtual++;
        }
    }

  
}
