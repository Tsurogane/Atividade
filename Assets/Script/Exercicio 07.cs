using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    public int numeroDeFaces; 

    void Start()
    {
        Rolagem(); 
    }

    void Rolagem()
    {
       
        if (numeroDeFaces < 1)
        {
            print("N�mero de faces deve ser maior que 0");
            return;
        }

        // Rolagem do dado
        int resultado = Random.Range(1, numeroDeFaces + 1); 
        print("Resultado da rolagem: " + resultado);
    }
}
