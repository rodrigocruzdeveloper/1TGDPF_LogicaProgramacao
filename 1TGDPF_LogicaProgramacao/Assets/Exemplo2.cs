using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    /*
     * CRIE UM PROGRAMA QUE RECEBE O NOME DE UM FUNCIONARIO QUANTAS HORAS 
     * ELE TRABALHOU E SEU VALOR HORA, EXIBA O QUANTO ELE GANHOU 
     * NO FINAL DO SEU TURNO DE TRABALHO
     */

    [SerializeField] private string nomeFuncionario;
    [SerializeField] private int horasTrabalhadas;
    [SerializeField] private float valorHora;
    
    void Start()
    {
        float salarioFinal = valorHora * horasTrabalhadas;
        print(nomeFuncionario + " você irá receber: " + salarioFinal);
    }
   
}
