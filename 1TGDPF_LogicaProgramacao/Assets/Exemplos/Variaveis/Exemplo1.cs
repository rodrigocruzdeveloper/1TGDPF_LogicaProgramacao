using UnityEngine;

public class Exemplo1 : MonoBehaviour
{
    [SerializeField] private string produto;
    [SerializeField] private float valorProduto;
    [SerializeField] private float desconto;

    void Start()
    {
        int a = 10;
        int b = 5;
        int c = 15;

        print("A + B: " + (a + b));
        print("A - B: " + (a - b));
        print("A * B: " + (a * b));
        print("A / B: " + (a / b));
        print("C / 2: " + (c / 2));
        print("C % 2: " + (c % 2));

        /*
        print(produto + " seu valor é:" + valorProduto);

        float valorDesconto = valorProduto * (desconto / 100);

        valorProduto = valorProduto - valorDesconto;

        print(produto + " valor com desconto: " + valorProduto);
        */

    } 
   
}
