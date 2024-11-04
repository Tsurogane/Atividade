using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    public int numeroDeFaces; // Definido pelo usuário

    void Start()
    {
        Rolagem(); // Chama a função de rolagem no início do jogo
    }

    void Rolagem()
    {
        // Verifica se o número de faces é válido
        if (numeroDeFaces < 1)
        {
            print("Número de faces deve ser maior que 0");
            return;
        }

        // Rolagem do dado
        int resultado = Random.Range(1, numeroDeFaces + 1); // +1 para incluir a face máxima
        print("Resultado da rolagem: " + resultado);
    }
}
